
namespace Presentacion
{
    partial class FormOpcionesDetallado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesDetallado));
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelCliente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelProveedor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFactura = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.redondeoCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoProveedor = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoFactura = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSubmenu.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelProveedor.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.panelFactura);
            this.panelSubmenu.Controls.Add(this.panelCliente);
            this.panelSubmenu.Controls.Add(this.panelProveedor);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 172);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(809, 290);
            this.panelSubmenu.TabIndex = 11;
            // 
            // panelCliente
            // 
            this.panelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCliente.BackgroundImage")));
            this.panelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCliente.Controls.Add(this.btnCliente);
            this.panelCliente.Controls.Add(this.lblCliente);
            this.panelCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCliente.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCliente.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCliente.Location = new System.Drawing.Point(89, 58);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Quality = 10;
            this.panelCliente.Size = new System.Drawing.Size(192, 179);
            this.panelCliente.TabIndex = 1;
            this.panelCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.panelCliente.Enter += new System.EventHandler(this.panelGeneral_Enter);
            this.panelCliente.MouseEnter += new System.EventHandler(this.panelGeneral_Enter);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.Location = new System.Drawing.Point(73, 101);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(50, 50);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.btnCliente.Enter += new System.EventHandler(this.panelGeneral_Enter);
            this.btnCliente.MouseEnter += new System.EventHandler(this.panelGeneral_Enter);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCliente.Location = new System.Drawing.Point(33, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(118, 36);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.lblCliente.Enter += new System.EventHandler(this.panelGeneral_Enter);
            this.lblCliente.MouseEnter += new System.EventHandler(this.panelGeneral_Enter);
            // 
            // panelProveedor
            // 
            this.panelProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProveedor.BackgroundImage")));
            this.panelProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProveedor.Controls.Add(this.btnProveedor);
            this.panelProveedor.Controls.Add(this.lblProveedor);
            this.panelProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProveedor.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelProveedor.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelProveedor.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelProveedor.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelProveedor.Location = new System.Drawing.Point(310, 58);
            this.panelProveedor.Name = "panelProveedor";
            this.panelProveedor.Quality = 10;
            this.panelProveedor.Size = new System.Drawing.Size(192, 179);
            this.panelProveedor.TabIndex = 2;
            this.panelProveedor.Click += new System.EventHandler(this.panelProveedor_Click);
            this.panelProveedor.Enter += new System.EventHandler(this.panelDetallado_Enter);
            this.panelProveedor.MouseEnter += new System.EventHandler(this.panelDetallado_Enter);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.BackgroundImage")));
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnProveedor.Location = new System.Drawing.Point(77, 101);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(50, 50);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.panelProveedor_Click);
            this.btnProveedor.Enter += new System.EventHandler(this.panelDetallado_Enter);
            this.btnProveedor.MouseEnter += new System.EventHandler(this.panelDetallado_Enter);
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblProveedor.Location = new System.Drawing.Point(21, 34);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(163, 36);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProveedor.Click += new System.EventHandler(this.panelProveedor_Click);
            this.lblProveedor.Enter += new System.EventHandler(this.panelDetallado_Enter);
            this.lblProveedor.MouseEnter += new System.EventHandler(this.panelDetallado_Enter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(809, 172);
            this.panelTitulo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(111, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(586, 63);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CUENTAS DETALLADAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFactura
            // 
            this.panelFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFactura.BackgroundImage")));
            this.panelFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFactura.Controls.Add(this.btnFactura);
            this.panelFactura.Controls.Add(this.lblFactura);
            this.panelFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFactura.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelFactura.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelFactura.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelFactura.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelFactura.Location = new System.Drawing.Point(531, 58);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Quality = 10;
            this.panelFactura.Size = new System.Drawing.Size(192, 179);
            this.panelFactura.TabIndex = 3;
            this.panelFactura.Click += new System.EventHandler(this.panelFactura_Click);
            this.panelFactura.Enter += new System.EventHandler(this.panelFactura_Enter);
            this.panelFactura.MouseEnter += new System.EventHandler(this.panelFactura_Enter);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFactura.BackgroundImage")));
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnFactura.Location = new System.Drawing.Point(74, 101);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(0);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(50, 50);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.panelFactura_Click);
            this.btnFactura.Enter += new System.EventHandler(this.panelFactura_Enter);
            this.btnFactura.MouseEnter += new System.EventHandler(this.panelFactura_Enter);
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblFactura.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblFactura.Location = new System.Drawing.Point(37, 35);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(125, 36);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura";
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFactura.Click += new System.EventHandler(this.panelFactura_Click);
            this.lblFactura.Enter += new System.EventHandler(this.panelFactura_Enter);
            this.lblFactura.MouseEnter += new System.EventHandler(this.panelFactura_Enter);
            // 
            // redondeoCliente
            // 
            this.redondeoCliente.ElipseRadius = 20;
            this.redondeoCliente.TargetControl = this.panelCliente;
            // 
            // redondeoProveedor
            // 
            this.redondeoProveedor.ElipseRadius = 20;
            this.redondeoProveedor.TargetControl = this.panelProveedor;
            // 
            // redondeoFactura
            // 
            this.redondeoFactura.ElipseRadius = 20;
            this.redondeoFactura.TargetControl = this.panelFactura;
            // 
            // FormOpcionesDetallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(809, 462);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionesDetallado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesDetallado";
            this.Shown += new System.EventHandler(this.FormOpcionesDetallado_Shown);
            this.Resize += new System.EventHandler(this.FormOpcionesDetallado_Resize);
            this.panelSubmenu.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panelProveedor.ResumeLayout(false);
            this.panelProveedor.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSubmenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblCliente;
        private Bunifu.Framework.UI.BunifuGradientPanel panelProveedor;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label lblProveedor;
        public System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuGradientPanel panelFactura;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Label lblFactura;
        private Bunifu.Framework.UI.BunifuElipse redondeoCliente;
        private Bunifu.Framework.UI.BunifuElipse redondeoProveedor;
        private Bunifu.Framework.UI.BunifuElipse redondeoFactura;
    }
}