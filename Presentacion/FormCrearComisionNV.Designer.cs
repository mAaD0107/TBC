namespace Presentacion
{
    partial class FormCrearComisionNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearComisionNV));
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Label();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panelGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.txtComisionTBC = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelSubtotalLDM = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotalLDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape38 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelSubtotalLDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPropiedades
            // 
            this.panelPropiedades.Controls.Add(this.cerrar);
            this.panelPropiedades.Controls.Add(this.maximizar);
            this.panelPropiedades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPropiedades.Location = new System.Drawing.Point(0, 0);
            this.panelPropiedades.Name = "panelPropiedades";
            this.panelPropiedades.Size = new System.Drawing.Size(1050, 37);
            this.panelPropiedades.TabIndex = 2;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.cerrar.Location = new System.Drawing.Point(1011, 7);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(17, 16);
            this.cerrar.TabIndex = 7;
            this.cerrar.Text = "X";
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(990, 8);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(15, 15);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 8;
            this.maximizar.TabStop = false;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelTitulo);
            this.panelGeneral.Controls.Add(this.panelFiltros);
            this.panelGeneral.Controls.Add(this.panelSubtotalLDM);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 37);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1050, 743);
            this.panelGeneral.TabIndex = 3;
            this.panelGeneral.Resize += new System.EventHandler(this.panelGeneral_Resize);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1008, 81);
            this.panelTitulo.TabIndex = 35;
            this.panelTitulo.Resize += new System.EventHandler(this.panelTitulo_Resize);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(311, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 56);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "NOTA DE VENTA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.label45);
            this.panelFiltros.Controls.Add(this.txtComisionTBC);
            this.panelFiltros.Controls.Add(this.txtEmpresa);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.cmbNombres);
            this.panelFiltros.Controls.Add(this.lblEmpresa);
            this.panelFiltros.Controls.Add(this.shapeContainer2);
            this.panelFiltros.Location = new System.Drawing.Point(3, 90);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1008, 217);
            this.panelFiltros.TabIndex = 38;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label45.Location = new System.Drawing.Point(265, 175);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(16, 18);
            this.label45.TabIndex = 62;
            this.label45.Text = "$";
            // 
            // txtComisionTBC
            // 
            this.txtComisionTBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtComisionTBC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComisionTBC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComisionTBC.ForeColor = System.Drawing.Color.White;
            this.txtComisionTBC.Location = new System.Drawing.Point(159, 178);
            this.txtComisionTBC.Name = "txtComisionTBC";
            this.txtComisionTBC.Size = new System.Drawing.Size(107, 19);
            this.txtComisionTBC.TabIndex = 61;
            this.txtComisionTBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.ForeColor = System.Drawing.Color.White;
            this.txtEmpresa.Location = new System.Drawing.Point(182, 114);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(224, 20);
            this.txtEmpresa.TabIndex = 60;
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(31, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Número Nota Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Comisión TBC:";
            // 
            // cmbNombres
            // 
            this.cmbNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cmbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres.ForeColor = System.Drawing.Color.Transparent;
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Items.AddRange(new object[] {
            "Rita Delgado",
            "Edgar Gallegos"});
            this.cmbNombres.Location = new System.Drawing.Point(111, 47);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(234, 28);
            this.cmbNombres.TabIndex = 56;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblEmpresa.Location = new System.Drawing.Point(31, 52);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(74, 18);
            this.lblEmpresa.TabIndex = 49;
            this.lblEmpresa.Text = "Nombres:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape24,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.lineShape8});
            this.shapeContainer2.Size = new System.Drawing.Size(1006, 215);
            this.shapeContainer2.TabIndex = 50;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape24
            // 
            this.lineShape24.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape24.Enabled = false;
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = 153;
            this.lineShape24.X2 = 282;
            this.lineShape24.Y1 = 197;
            this.lineShape24.Y2 = 197;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 27;
            this.lineShape3.X2 = 27;
            this.lineShape3.Y1 = 136;
            this.lineShape3.Y2 = 113;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 177;
            this.lineShape2.X2 = 405;
            this.lineShape2.Y1 = 136;
            this.lineShape2.Y2 = 136;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 26;
            this.lineShape1.Y1 = 198;
            this.lineShape1.Y2 = 175;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape8.Enabled = false;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 27;
            this.lineShape8.X2 = 27;
            this.lineShape8.Y1 = 73;
            this.lineShape8.Y2 = 50;
            // 
            // panelSubtotalLDM
            // 
            this.panelSubtotalLDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubtotalLDM.Controls.Add(this.label6);
            this.panelSubtotalLDM.Controls.Add(this.txtSubtotalLDM);
            this.panelSubtotalLDM.Controls.Add(this.label4);
            this.panelSubtotalLDM.Controls.Add(this.shapeContainer3);
            this.panelSubtotalLDM.Location = new System.Drawing.Point(3, 313);
            this.panelSubtotalLDM.Name = "panelSubtotalLDM";
            this.panelSubtotalLDM.Size = new System.Drawing.Size(1007, 101);
            this.panelSubtotalLDM.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(500, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 42);
            this.label6.TabIndex = 55;
            this.label6.Text = "$";
            // 
            // txtSubtotalLDM
            // 
            this.txtSubtotalLDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtSubtotalLDM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotalLDM.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalLDM.ForeColor = System.Drawing.Color.DimGray;
            this.txtSubtotalLDM.Location = new System.Drawing.Point(276, 19);
            this.txtSubtotalLDM.Name = "txtSubtotalLDM";
            this.txtSubtotalLDM.Size = new System.Drawing.Size(231, 46);
            this.txtSubtotalLDM.TabIndex = 4;
            this.txtSubtotalLDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(31, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "SUBTOTAL LDM:";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape38,
            this.lineShape4});
            this.shapeContainer3.Size = new System.Drawing.Size(1005, 99);
            this.shapeContainer3.TabIndex = 54;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape38
            // 
            this.lineShape38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape38.Enabled = false;
            this.lineShape38.Name = "lineShape38";
            this.lineShape38.X1 = 27;
            this.lineShape38.X2 = 27;
            this.lineShape38.Y1 = 59;
            this.lineShape38.Y2 = 28;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape2";
            this.lineShape4.X1 = 269;
            this.lineShape4.X2 = 531;
            this.lineShape4.Y1 = 65;
            this.lineShape4.Y2 = 65;
            // 
            // FormCrearComisionNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1050, 780);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrearComisionNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearComisionNV";
            this.Load += new System.EventHandler(this.FormCrearComisionNV_Load);
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelSubtotalLDM.ResumeLayout(false);
            this.panelSubtotalLDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelGeneral;
        private System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.Label lblEmpresa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        public System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public System.Windows.Forms.TextBox txtComisionTBC;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape24;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panelSubtotalLDM;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSubtotalLDM;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape38;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
    }
}