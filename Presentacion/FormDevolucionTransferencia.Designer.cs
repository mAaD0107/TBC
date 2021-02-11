
namespace Presentacion
{
    partial class FormDevolucionTransferencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevolucionTransferencia));
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Label();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesde = new System.Windows.Forms.Panel();
            this.dateDevolucion = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalleDevolucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panelDevolucion = new System.Windows.Forms.Panel();
            this.txtValorDevolucion = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape25 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.redondeoBtnGuardar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panelDesde.SuspendLayout();
            this.panelDevolucion.SuspendLayout();
            this.panelInferior.SuspendLayout();
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
            this.panelPropiedades.TabIndex = 87;
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
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.panel18);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panelDesde);
            this.panelContenedor.Controls.Add(this.panelDevolucion);
            this.panelContenedor.Controls.Add(this.panelInferior);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 743);
            this.panelContenedor.TabIndex = 88;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.lblTitulo);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1008, 75);
            this.panel18.TabIndex = 36;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.lblTitulo.Location = new System.Drawing.Point(224, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(567, 58);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "SALDO TRANSFERENCIA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 75);
            this.panel2.TabIndex = 39;
            // 
            // panelDesde
            // 
            this.panelDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesde.Controls.Add(this.dateDevolucion);
            this.panelDesde.Controls.Add(this.label4);
            this.panelDesde.Controls.Add(this.txtDetalleDevolucion);
            this.panelDesde.Controls.Add(this.label5);
            this.panelDesde.Controls.Add(this.lblDetalle);
            this.panelDesde.Location = new System.Drawing.Point(3, 165);
            this.panelDesde.Name = "panelDesde";
            this.panelDesde.Size = new System.Drawing.Size(1008, 255);
            this.panelDesde.TabIndex = 42;
            // 
            // dateDevolucion
            // 
            this.dateDevolucion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dateDevolucion.BorderRadius = 0;
            this.dateDevolucion.ForeColor = System.Drawing.Color.White;
            this.dateDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDevolucion.FormatCustom = null;
            this.dateDevolucion.Location = new System.Drawing.Point(191, 182);
            this.dateDevolucion.Name = "dateDevolucion";
            this.dateDevolucion.Size = new System.Drawing.Size(382, 36);
            this.dateDevolucion.TabIndex = 81;
            this.dateDevolucion.Value = new System.DateTime(2021, 2, 8, 17, 47, 9, 159);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(132, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Fecha:";
            // 
            // txtDetalleDevolucion
            // 
            this.txtDetalleDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalleDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDetalleDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleDevolucion.ForeColor = System.Drawing.Color.LightGray;
            this.txtDetalleDevolucion.Location = new System.Drawing.Point(191, 99);
            this.txtDetalleDevolucion.Multiline = true;
            this.txtDetalleDevolucion.Name = "txtDetalleDevolucion";
            this.txtDetalleDevolucion.Size = new System.Drawing.Size(382, 50);
            this.txtDetalleDevolucion.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(73, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Observaciones:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.lblDetalle.Location = new System.Drawing.Point(15, 17);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(339, 36);
            this.lblDetalle.TabIndex = 80;
            this.lblDetalle.Text = "DETALLE DEVOLUCIÓN:";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDevolucion
            // 
            this.panelDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDevolucion.Controls.Add(this.txtValorDevolucion);
            this.panelDevolucion.Controls.Add(this.lblVal);
            this.panelDevolucion.Controls.Add(this.shapeContainer2);
            this.panelDevolucion.Location = new System.Drawing.Point(3, 426);
            this.panelDevolucion.Name = "panelDevolucion";
            this.panelDevolucion.Size = new System.Drawing.Size(1008, 138);
            this.panelDevolucion.TabIndex = 41;
            // 
            // txtValorDevolucion
            // 
            this.txtValorDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtValorDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDevolucion.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDevolucion.ForeColor = System.Drawing.Color.White;
            this.txtValorDevolucion.Location = new System.Drawing.Point(270, 40);
            this.txtValorDevolucion.Name = "txtValorDevolucion";
            this.txtValorDevolucion.Size = new System.Drawing.Size(240, 46);
            this.txtValorDevolucion.TabIndex = 63;
            this.txtValorDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDevolucion.WordWrap = false;
            this.txtValorDevolucion.TextChanged += new System.EventHandler(this.txtValorDevolucion_TextChanged);
            this.txtValorDevolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDevolucion_KeyPress);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblVal.Location = new System.Drawing.Point(47, 51);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(192, 25);
            this.lblVal.TabIndex = 64;
            this.lblVal.Text = "Valor a devolver: $";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape25});
            this.shapeContainer2.Size = new System.Drawing.Size(1006, 136);
            this.shapeContainer2.TabIndex = 65;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape25
            // 
            this.lineShape25.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape25.Enabled = false;
            this.lineShape25.Name = "lineShape25";
            this.lineShape25.X1 = 253;
            this.lineShape25.X2 = 518;
            this.lineShape25.Y1 = 86;
            this.lineShape25.Y2 = 86;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnGuardar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(3, 570);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1008, 61);
            this.panelInferior.TabIndex = 38;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnGuardar.Location = new System.Drawing.Point(314, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(387, 44);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // redondeoBtnGuardar
            // 
            this.redondeoBtnGuardar.ElipseRadius = 20;
            this.redondeoBtnGuardar.TargetControl = this.btnGuardar;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormDevolucionTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1050, 780);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormDevolucionTransferencia";
            this.Text = "FormDevolucionTransferencia";
            this.Shown += new System.EventHandler(this.FormDevolucionTransferencia_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDevolucionTransferencia_KeyDown);
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panelDesde.ResumeLayout(false);
            this.panelDesde.PerformLayout();
            this.panelDevolucion.ResumeLayout(false);
            this.panelDevolucion.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
        private System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesde;
        private Bunifu.Framework.UI.BunifuDatepicker dateDevolucion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDetalleDevolucion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel panelDevolucion;
        public System.Windows.Forms.TextBox txtValorDevolucion;
        private System.Windows.Forms.Label lblVal;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape25;
        public System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnGuardar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}