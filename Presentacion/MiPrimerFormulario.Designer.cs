namespace Presentacion
{
    partial class MiPrimerFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPrimerFormulario));
            this.AniadirBoton = new System.Windows.Forms.Button();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.ReporteBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.SalirBoton = new System.Windows.Forms.Button();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.TbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaCaja = new System.Windows.Forms.ListBox();
            this.ListaCajaDescrip = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.TbBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AniadirBoton
            // 
            this.AniadirBoton.Location = new System.Drawing.Point(26, 292);
            this.AniadirBoton.Name = "AniadirBoton";
            this.AniadirBoton.Size = new System.Drawing.Size(122, 49);
            this.AniadirBoton.TabIndex = 0;
            this.AniadirBoton.Text = "Añadir";
            this.AniadirBoton.UseVisualStyleBackColor = true;
            this.AniadirBoton.Click += new System.EventHandler(this.AniadirBoton_Click);
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.Location = new System.Drawing.Point(154, 292);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(122, 49);
            this.ActualizarBoton.TabIndex = 1;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = true;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // ReporteBoton
            // 
            this.ReporteBoton.Location = new System.Drawing.Point(410, 292);
            this.ReporteBoton.Name = "ReporteBoton";
            this.ReporteBoton.Size = new System.Drawing.Size(122, 49);
            this.ReporteBoton.TabIndex = 3;
            this.ReporteBoton.Text = "Descargar CSV";
            this.ReporteBoton.UseVisualStyleBackColor = true;
            this.ReporteBoton.Click += new System.EventHandler(this.ReporteBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(282, 292);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(122, 49);
            this.EliminarBoton.TabIndex = 2;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // SalirBoton
            // 
            this.SalirBoton.Location = new System.Drawing.Point(538, 292);
            this.SalirBoton.Name = "SalirBoton";
            this.SalirBoton.Size = new System.Drawing.Size(122, 49);
            this.SalirBoton.TabIndex = 4;
            this.SalirBoton.Text = "Salir";
            this.SalirBoton.UseVisualStyleBackColor = true;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.codigoLabel.Location = new System.Drawing.Point(29, 118);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 5;
            this.codigoLabel.Text = "Codigo";
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(98, 115);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(100, 20);
            this.TbCodigo.TabIndex = 6;
            // 
            // TbDescripcion
            // 
            this.TbDescripcion.Location = new System.Drawing.Point(98, 141);
            this.TbDescripcion.Name = "TbDescripcion";
            this.TbDescripcion.Size = new System.Drawing.Size(213, 20);
            this.TbDescripcion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "ElectroCasa";
            // 
            // ListaCaja
            // 
            this.ListaCaja.FormattingEnabled = true;
            this.ListaCaja.Location = new System.Drawing.Point(383, 79);
            this.ListaCaja.Name = "ListaCaja";
            this.ListaCaja.Size = new System.Drawing.Size(129, 186);
            this.ListaCaja.TabIndex = 10;
            this.ListaCaja.SelectedIndexChanged += new System.EventHandler(this.ListaCaja_SelectedIndexChanged);
            // 
            // ListaCajaDescrip
            // 
            this.ListaCajaDescrip.FormattingEnabled = true;
            this.ListaCajaDescrip.Location = new System.Drawing.Point(518, 79);
            this.ListaCajaDescrip.Name = "ListaCajaDescrip";
            this.ListaCajaDescrip.Size = new System.Drawing.Size(120, 186);
            this.ListaCajaDescrip.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(380, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(515, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarBoton);
            this.groupBox1.Controls.Add(this.TbBusca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(26, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(205, 18);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(81, 23);
            this.BuscarBoton.TabIndex = 21;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // TbBusca
            // 
            this.TbBusca.Location = new System.Drawing.Point(6, 19);
            this.TbBusca.Name = "TbBusca";
            this.TbBusca.Size = new System.Drawing.Size(194, 20);
            this.TbBusca.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad de busquedas relacionadas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MiPrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(682, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaCajaDescrip);
            this.Controls.Add(this.ListaCaja);
            this.Controls.Add(this.TbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCodigo);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.SalirBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.ReporteBoton);
            this.Controls.Add(this.ActualizarBoton);
            this.Controls.Add(this.AniadirBoton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MiPrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroCasa: Sistema de Gestion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AniadirBoton;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.Button ReporteBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button SalirBoton;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.TextBox TbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListaCaja;
        private System.Windows.Forms.ListBox ListaCajaDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.TextBox TbBusca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}