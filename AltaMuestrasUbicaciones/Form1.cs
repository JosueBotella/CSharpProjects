using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;

namespace AltaMuestrasUbicaciones
{
    public partial class Form1 : Form
    {
        ListViewItem elementoListView;
        string sageID = "";
        string muestraID = "";
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
        }
        private void productoeantxbox_KeyDown(object sender, KeyEventArgs e)
        {

            string barcode = productoeantxbox.Text;
            if (e.KeyCode == System.Windows.Forms.Keys.Return)
            {
                //Comprobamos si el barcode tickado longitud correcta. 
                if (productoeantxbox.Text.Length > 0 && productoeantxbox.Text.Length < 14)
                {
                    listaResultados.Items.Clear();
                    string codeEan = productoeantxbox.Text;
                    if (codeEan.Length == 12) codeEan = "0" + codeEan;
                    
                    //Tickamos producto e asignamos a variable local su valor                    
                    esProductolb.Text = productoeantxbox.Text;                    
                    existeArticulo(codeEan);
                    productoeantxbox.Text = "";
                    btn_aplicar.Enabled = true;
                }
                else { MessageBox.Show("PRODUCTO INCORRECTO, CODIGO EAN DEMASIADO LARGO."); }
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Quieres asignar la ubicación a la muestra?", "Si o No?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Elemento con sage :"+sageID+" y ubicacion "+muestraID);
                productoUbicado();
                sageID = "";
                muestraID = "";
                //MessageBox.Show("Elemento con ubicación:" + listaResultados.SelectedItems["CodigoArticulo"]);
            }
            else { MessageBox.Show("Elemento con ubicación:"); }
        }

        private void existeArticulo(string barcode)
        {           
            try
            {
                
                SqlConnection conectorSQL = new SqlConnection("user id=sa;password=Admin123admin;server=SRVSQL\\LOGICCLASS;database=lc_perfumesvalencia;connection timeout=30");
                string consulta = "SELECT  CodigoArticulo, DescripcionArticulo + Descripcion2Articulo AS descripcion, CodigoAlternativo, B_EsVapo, B_CodigoMarca, B_Muestra ";
                consulta += " FROM  Articulos WHERE  (CodigoAlternativo = '"+barcode+"')";
                conectorSQL.Open();
                SqlCommand comando = new SqlCommand(consulta, conectorSQL);
                SqlDataReader datos = comando.ExecuteReader();
                
                if (datos.HasRows) {
                    string[] elementosFila = new string[5];                                        
                    while (datos.Read()) //returing false 
                    {
                        try{
                            //Tipo de muestras
                            string[] tipoMuestra = new string[] { "Normal", "Vapo 2,5ml", "No Vapo 2,5ml", "Cabello", "Tester", "No Vapo 1 ml.", "Cabello 20ml", "Cabello 30ml","No Vapo 2,5ml" };
                            //Preparamos la ubicación en valores correctos. 
                            string valormuestra = "";
                            if (datos["B_Muestra"].ToString().Length == 1)
                            {
                                 valormuestra = "900" + datos["B_Muestra"].ToString();                                
                            }

                            else if (datos["B_Muestra"].ToString().Length == 2)
                            {                                
                                 valormuestra = "90" + datos["B_Muestra"].ToString(); 
                            }
                            else if (datos["B_Muestra"].ToString().Length == 3)
                            {
                                 valormuestra = "9" + datos["B_Muestra"].ToString();                               
                            }
                            //Añadimos una primera fila al ListView
                            elementosFila[0] = datos["CodigoArticulo"].ToString();
                            elementosFila[1] = datos["descripcion"].ToString();
                            elementosFila[2] = datos["CodigoAlternativo"].ToString();                            
                            elementosFila[3] = tipoMuestra[int.Parse(datos["B_EsVapo"].ToString())];
                            elementosFila[4] = valormuestra;
                            elementoListView = new ListViewItem(elementosFila);
                            listaResultados.Items.Add(elementoListView);

                            sageID = datos["CodigoArticulo"].ToString();
                            sagelb.Text = datos["CodigoArticulo"].ToString();
                            muestraID = valormuestra;
                            }
                        catch
                        {
                            MessageBox.Show("List Fails Load");
                        }
                    }                                                        
                } else { MessageBox.Show("SQL KO producto"); }
                    
                
                conectorSQL.Close();
            }
            catch
            { 
                MessageBox.Show("FAILS SQL ");
            }
        }


        private void productoUbicado()
        {
            try
            {
                MessageBox.Show(sageID);
                //BOOLEANO PARA REALIZAR INSERT.
                bool insertadoJose_articuloMarcaContador = true;
                bool insertaUbicaciones = true;
                string codigomarca = "366";
                SqlConnection conectorSQL = new SqlConnection("user id=sa;password=Admin123admin;server=SRVSQL\\LOGICCLASS;database=lc_perfumesvalencia;connection timeout=30");
                string consultaArticulosMarcaContador = "SELECT     CodigoArticulo FROM   jose_ArticulosMarcaContador WHERE     (Valor = '" + muestraID + "') AND (B_CodigoMarca = '" + codigomarca + "') AND (CodigoArticulo = '" + sageID + "')";
                string consultaUbicaciones = "SELECT     CodigoEmpresa, CodigoAlmacen, Ubicacion, DescripcionUbicacion  FROM  Ubicaciones  WHERE     (Ubicacion ='" + sagelb.Text + "')";
                //PRIMERA CONEXIÓN SQL. 
                conectorSQL.Open();                                                
                SqlCommand comando = new SqlCommand(consultaArticulosMarcaContador, conectorSQL);                
                SqlDataReader datosArtMarcaCont = comando.ExecuteReader();
               
                //             
                if (!datosArtMarcaCont.HasRows) { insertadoJose_articuloMarcaContador = false; }
                
                conectorSQL.Close();
                conectorSQL.Open();
                                
                SqlCommand comando2 = new SqlCommand(consultaUbicaciones, conectorSQL);
                SqlDataReader datosUbicaciones = comando2.ExecuteReader();
                if (!datosUbicaciones.HasRows) { insertaUbicaciones = false; }

                conectorSQL.Close();        
        
                //PROCEDEMOS A REALIZAR INSERT DEL MISMO. 
                if (!insertadoJose_articuloMarcaContador && !insertaUbicaciones) {

                    string insertaArtiMarcaContador = "insert into jose_ArticulosMarcaContador values ('"+sagelb.Text+"','366','"+ muestraID + "')";
                    string insertaUbicacionesON= "insert into Ubicaciones values ('1','CEN','"+sagelb.Text+"','NOVA-"+muestraID+"')";
                    MessageBox.Show(insertaArtiMarcaContador);
                    MessageBox.Show(insertaUbicacionesON);

                    SqlCommand comando3 = new SqlCommand(insertaArtiMarcaContador, conectorSQL);
                    SqlCommand comando4 = new SqlCommand(insertaUbicacionesON, conectorSQL);
                    try
                    {
                        conectorSQL.Open();
                        int recordsAffected = comando3.ExecuteNonQuery();
                        conectorSQL.Close();
                        conectorSQL.Open();
                        int recordsAffectedtwo = comando4.ExecuteNonQuery();
                        conectorSQL.Close();
                        if (recordsAffected > 0) { MessageBox.Show("INSERT OK"); } else if (recordsAffectedtwo > 0) { MessageBox.Show("INSERT2 OK"); }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("INSERT FALLIDO");
                    }                                      
                }

                btn_aplicar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("FALLO EN EL INSERT2 ");
            }

        }
       
    }
}
