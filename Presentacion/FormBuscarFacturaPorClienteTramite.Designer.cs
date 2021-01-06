
namespace Presentacion
{
    partial class FormBuscarFacturaPorClienteTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFacturaPorClienteTramite));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelCliente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelTramite = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnTramite = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.redondeoCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoTramite = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelOpciones.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelTramite.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelCliente);
            this.panelOpciones.Controls.Add(this.panelTramite);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(800, 278);
            this.panelOpciones.TabIndex = 7;
            // 
            // panelCliente
            // 
            this.panelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCliente.BackgroundImage")));
            this.panelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCliente.Controls.Add(this.lblCliente);
            this.panelCliente.Controls.Add(this.btnCliente);
            this.panelCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCliente.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCliente.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCliente.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCliente.Location = new System.Drawing.Point(214, 43);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Quality = 10;
            this.panelCliente.Size = new System.Drawing.Size(192, 179);
            this.panelCliente.TabIndex = 2;
            this.panelCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.panelCliente.Enter += new System.EventHandler(this.panelCliente_MouseEnter);
            this.panelCliente.MouseEnter += new System.EventHandler(this.panelCliente_MouseEnter);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCliente.Location = new System.Drawing.Point(39, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(118, 36);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.lblCliente.MouseEnter += new System.EventHandler(this.panelCliente_MouseEnter);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnCliente.Location = new System.Drawing.Point(73, 92);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(50, 50);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.panelCliente_Click);
            this.btnCliente.MouseEnter += new System.EventHandler(this.panelCliente_MouseEnter);
            // 
            // panelTramite
            // 
            this.panelTramite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelTramite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTramite.BackgroundImage")));
            this.panelTramite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTramite.Controls.Add(this.btnTramite);
            this.panelTramite.Controls.Add(this.lblTramite);
            this.panelTramite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTramite.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelTramite.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelTramite.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelTramite.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelTramite.Location = new System.Drawing.Point(441, 43);
            this.panelTramite.Name = "panelTramite";
            this.panelTramite.Quality = 10;
            this.panelTramite.Size = new System.Drawing.Size(192, 179);
            this.panelTramite.TabIndex = 1;
            this.panelTramite.Click += new System.EventHandler(this.panelTramite_Click);
            this.panelTramite.Enter += new System.EventHandler(this.panelTramite_MouseEnter);
            this.panelTramite.MouseEnter += new System.EventHandler(this.panelTramite_MouseEnter);
            // 
            // btnTramite
            // 
            this.btnTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTramite.BackgroundImage")));
            this.btnTramite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTramite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnTramite.Location = new System.Drawing.Point(77, 92);
            this.btnTramite.Margin = new System.Windows.Forms.Padding(0);
            this.btnTramite.Name = "btnTramite";
            this.btnTramite.Size = new System.Drawing.Size(50, 50);
            this.btnTramite.TabIndex = 2;
            this.btnTramite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTramite.UseVisualStyleBackColor = false;
            this.btnTramite.Click += new System.EventHandler(this.panelTramite_Click);
            this.btnTramite.MouseEnter += new System.EventHandler(this.panelTramite_MouseEnter);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.BackColor = System.Drawing.Color.Transparent;
            this.lblTramite.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblTramite.Location = new System.Drawing.Point(42, 35);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(121, 36);
            this.lblTramite.TabIndex = 0;
            this.lblTramite.Text = "Trámite\r\n";
            this.lblTramite.Click += new System.EventHandler(this.panelTramite_Click);
            this.lblTramite.MouseEnter += new System.EventHandler(this.panelTramite_MouseEnter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 172);
            this.panelTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(175, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(482, 63);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CLIENTE / TRÁMITE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redondeoCliente
            // 
            this.redondeoCliente.ElipseRadius = 20;
            this.redondeoCliente.TargetControl = this.panelCliente;
            // 
            // redondeoTramite
            // 
            this.redondeoTramite.ElipseRadius = 20;
            this.redondeoTramite.TargetControl = this.panelTramite;
            // 
            // FormBuscarFacturaPorClienteTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarFacturaPorClienteTramite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarFacturaPorCliente";
            this.panelOpciones.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panelTramite.ResumeLayout(false);
            this.panelTramite.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCliente;
        private System.Windows.Forms.Button btnTramite;
        private System.Windows.Forms.Label lblCliente;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTramite;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse redondeoCliente;
        private Bunifu.Framework.UI.BunifuElipse redondeoTramite;
    }
}