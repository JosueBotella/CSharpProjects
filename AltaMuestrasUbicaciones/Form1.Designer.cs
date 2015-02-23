namespace AltaMuestrasUbicaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.productoLb = new System.Windows.Forms.Label();
            this.productoeantxbox = new System.Windows.Forms.TextBox();
            this.esProductolb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaResultados = new System.Windows.Forms.ListView();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.codigoarticulocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcioncol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoalternativocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipomuestracol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ubicacioncol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sagelb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productoLb
            // 
            this.productoLb.AutoSize = true;
            this.productoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLb.ForeColor = System.Drawing.Color.Red;
            this.productoLb.Location = new System.Drawing.Point(12, 28);
            this.productoLb.Name = "productoLb";
            this.productoLb.Size = new System.Drawing.Size(131, 17);
            this.productoLb.TabIndex = 0;
            this.productoLb.Text = "PRODUCTO EAN";
            // 
            // productoeantxbox
            // 
            this.productoeantxbox.Location = new System.Drawing.Point(163, 28);
            this.productoeantxbox.Name = "productoeantxbox";
            this.productoeantxbox.Size = new System.Drawing.Size(263, 20);
            this.productoeantxbox.TabIndex = 1;
            this.productoeantxbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productoeantxbox_KeyDown);
            // 
            // esProductolb
            // 
            this.esProductolb.AutoSize = true;
            this.esProductolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esProductolb.Location = new System.Drawing.Point(670, 28);
            this.esProductolb.Name = "esProductolb";
            this.esProductolb.Size = new System.Drawing.Size(61, 20);
            this.esProductolb.TabIndex = 2;
            this.esProductolb.Text = "NONE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Último Tickado:";
            // 
            // listaResultados
            // 
            this.listaResultados.BackColor = System.Drawing.SystemColors.Info;
            this.listaResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoarticulocol,
            this.descripcioncol,
            this.codigoalternativocol,
            this.tipomuestracol,
            this.ubicacioncol});
            this.listaResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaResultados.ForeColor = System.Drawing.Color.Red;
            this.listaResultados.FullRowSelect = true;
            this.listaResultados.GridLines = true;
            this.listaResultados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaResultados.Location = new System.Drawing.Point(15, 78);
            this.listaResultados.MultiSelect = false;
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(1069, 116);
            this.listaResultados.TabIndex = 4;
            this.listaResultados.UseCompatibleStateImageBehavior = false;
            this.listaResultados.View = System.Windows.Forms.View.Details;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar.ForeColor = System.Drawing.Color.Red;
            this.btn_aplicar.Location = new System.Drawing.Point(797, 233);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(287, 73);
            this.btn_aplicar.TabIndex = 5;
            this.btn_aplicar.Text = "APLICAR UBICACION";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // codigoarticulocol
            // 
            this.codigoarticulocol.Text = "Codigo Articulo";
            this.codigoarticulocol.Width = 120;
            // 
            // descripcioncol
            // 
            this.descripcioncol.Text = "Descripcion Articulo ";
            this.descripcioncol.Width = 400;
            // 
            // codigoalternativocol
            // 
            this.codigoalternativocol.Text = "Codigo Alternativo";
            this.codigoalternativocol.Width = 150;
            // 
            // tipomuestracol
            // 
            this.tipomuestracol.Text = "Tipo Muestra";
            this.tipomuestracol.Width = 120;
            // 
            // ubicacioncol
            // 
            this.ubicacioncol.Text = "Ubicacion";
            this.ubicacioncol.Width = 80;
            // 
            // sagelb
            // 
            this.sagelb.AutoSize = true;
            this.sagelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sagelb.Location = new System.Drawing.Point(834, 28);
            this.sagelb.Name = "sagelb";
            this.sagelb.Size = new System.Drawing.Size(51, 20);
            this.sagelb.TabIndex = 6;
            this.sagelb.Text = "Sage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 729);
            this.Controls.Add(this.sagelb);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.listaResultados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esProductolb);
            this.Controls.Add(this.productoeantxbox);
            this.Controls.Add(this.productoLb);
            this.Name = "Form1";
            this.Text = "Altas Muestras - Ubicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productoLb;
        private System.Windows.Forms.TextBox productoeantxbox;
        private System.Windows.Forms.Label esProductolb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaResultados;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.ColumnHeader codigoarticulocol;
        private System.Windows.Forms.ColumnHeader descripcioncol;
        private System.Windows.Forms.ColumnHeader codigoalternativocol;
        private System.Windows.Forms.ColumnHeader tipomuestracol;
        private System.Windows.Forms.ColumnHeader ubicacioncol;
        private System.Windows.Forms.Label sagelb;
    }
}

