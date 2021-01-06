
namespace Presentacion
{
    partial class FormBuscarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFactura));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelporDetalle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panelPorTramite = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnTramiteCliente = new System.Windows.Forms.Button();
            this.lblTramiteCliente = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.redondeoPanelTramite = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoPanelDetalle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelOpciones.SuspendLayout();
            this.panelporDetalle.SuspendLayout();
            this.panelPorTramite.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelporDetalle);
            this.panelOpciones.Controls.Add(this.panelPorTramite);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(800, 278);
            this.panelOpciones.TabIndex = 5;
            // 
            // panelporDetalle
            // 
            this.panelporDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelporDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelporDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelporDetalle.BackgroundImage")));
            this.panelporDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelporDetalle.Controls.Add(this.btnDetalle);
            this.panelporDetalle.Controls.Add(this.lblDetalle);
            this.panelporDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelporDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelporDetalle.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelporDetalle.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelporDetalle.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelporDetalle.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelporDetalle.Location = new System.Drawing.Point(423, 43);
            this.panelporDetalle.Name = "panelporDetalle";
            this.panelporDetalle.Quality = 10;
            this.panelporDetalle.Size = new System.Drawing.Size(192, 179);
            this.panelporDetalle.TabIndex = 2;
            this.panelporDetalle.Click += new System.EventHandler(this.panelporDetalle_Click);
            this.panelporDetalle.Enter += new System.EventHandler(this.panelporDetalle_MouseEnter);
            this.panelporDetalle.MouseEnter += new System.EventHandler(this.panelporDetalle_MouseEnter);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetalle.BackgroundImage")));
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDetalle.Location = new System.Drawing.Point(76, 98);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(50, 50);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.panelporDetalle_Click);
            this.btnDetalle.MouseEnter += new System.EventHandler(this.panelporDetalle_MouseEnter);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblDetalle.Location = new System.Drawing.Point(43, 35);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(117, 36);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Detalle";
            this.lblDetalle.Click += new System.EventHandler(this.panelporDetalle_Click);
            this.lblDetalle.MouseEnter += new System.EventHandler(this.panelporDetalle_MouseEnter);
            // 
            // panelPorTramite
            // 
            this.panelPorTramite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPorTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelPorTramite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPorTramite.BackgroundImage")));
            this.panelPorTramite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPorTramite.Controls.Add(this.btnTramiteCliente);
            this.panelPorTramite.Controls.Add(this.lblTramiteCliente);
            this.panelPorTramite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPorTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPorTramite.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelPorTramite.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelPorTramite.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelPorTramite.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelPorTramite.Location = new System.Drawing.Point(204, 43);
            this.panelPorTramite.Name = "panelPorTramite";
            this.panelPorTramite.Quality = 10;
            this.panelPorTramite.Size = new System.Drawing.Size(192, 179);
            this.panelPorTramite.TabIndex = 1;
            this.panelPorTramite.Click += new System.EventHandler(this.panelPorTramite_Click);
            this.panelPorTramite.Enter += new System.EventHandler(this.panelPorTramite_MouseEnter);
            this.panelPorTramite.MouseEnter += new System.EventHandler(this.panelPorTramite_MouseEnter);
            // 
            // btnTramiteCliente
            // 
            this.btnTramiteCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnTramiteCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTramiteCliente.BackgroundImage")));
            this.btnTramiteCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTramiteCliente.FlatAppearance.BorderSize = 0;
            this.btnTramiteCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramiteCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramiteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramiteCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnTramiteCliente.Location = new System.Drawing.Point(74, 101);
            this.btnTramiteCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnTramiteCliente.Name = "btnTramiteCliente";
            this.btnTramiteCliente.Size = new System.Drawing.Size(50, 50);
            this.btnTramiteCliente.TabIndex = 1;
            this.btnTramiteCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTramiteCliente.UseVisualStyleBackColor = false;
            this.btnTramiteCliente.Click += new System.EventHandler(this.panelPorTramite_Click);
            this.btnTramiteCliente.MouseEnter += new System.EventHandler(this.panelPorTramite_MouseEnter);
            // 
            // lblTramiteCliente
            // 
            this.lblTramiteCliente.AutoSize = true;
            this.lblTramiteCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTramiteCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblTramiteCliente.Location = new System.Drawing.Point(39, 15);
            this.lblTramiteCliente.Name = "lblTramiteCliente";
            this.lblTramiteCliente.Size = new System.Drawing.Size(121, 72);
            this.lblTramiteCliente.TabIndex = 0;
            this.lblTramiteCliente.Text = "Cliente\r\nTrámite";
            this.lblTramiteCliente.Click += new System.EventHandler(this.panelPorTramite_Click);
            this.lblTramiteCliente.MouseEnter += new System.EventHandler(this.panelPorTramite_MouseEnter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 172);
            this.panelTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(175, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(451, 63);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BUSCAR - EDITAR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redondeoPanelTramite
            // 
            this.redondeoPanelTramite.ElipseRadius = 20;
            this.redondeoPanelTramite.TargetControl = this.panelPorTramite;
            // 
            // redondeoPanelDetalle
            // 
            this.redondeoPanelDetalle.ElipseRadius = 20;
            this.redondeoPanelDetalle.TargetControl = this.panelporDetalle;
            // 
            // FormBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarFactura";
            this.Shown += new System.EventHandler(this.FormBuscarFactura_Shown);
            this.panelOpciones.ResumeLayout(false);
            this.panelporDetalle.ResumeLayout(false);
            this.panelporDetalle.PerformLayout();
            this.panelPorTramite.ResumeLayout(false);
            this.panelPorTramite.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuGradientPanel panelporDetalle;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private Bunifu.Framework.UI.BunifuGradientPanel panelPorTramite;
        private System.Windows.Forms.Button btnTramiteCliente;
        private System.Windows.Forms.Label lblTramiteCliente;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse redondeoPanelTramite;
        private Bunifu.Framework.UI.BunifuElipse redondeoPanelDetalle;
    }
}