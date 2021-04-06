namespace Presentacion
{
    partial class FormOpcionesPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesPagos));
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelCrear = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCrear = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.redondeoBtnCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnBuscar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSubmenu.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.panelCrear);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 144);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(809, 318);
            this.panelSubmenu.TabIndex = 9;
            // 
            // panelCrear
            // 
            this.panelCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCrear.BackgroundImage")));
            this.panelCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCrear.Controls.Add(this.btnCrear);
            this.panelCrear.Controls.Add(this.lblCrear);
            this.panelCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCrear.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrear.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrear.Location = new System.Drawing.Point(301, 47);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Quality = 10;
            this.panelCrear.Size = new System.Drawing.Size(206, 179);
            this.panelCrear.TabIndex = 1;
            this.panelCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.panelCrear.Enter += new System.EventHandler(this.panelCrear_Enter);
            this.panelCrear.MouseEnter += new System.EventHandler(this.panelCrear_Enter);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.Location = new System.Drawing.Point(81, 99);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(50, 50);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.btnCrear.Enter += new System.EventHandler(this.panelCrear_Enter);
            this.btnCrear.MouseEnter += new System.EventHandler(this.panelCrear_Enter);
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCrear.Location = new System.Drawing.Point(62, 36);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(89, 33);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear";
            this.lblCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.lblCrear.Enter += new System.EventHandler(this.panelCrear_Enter);
            this.lblCrear.MouseEnter += new System.EventHandler(this.panelCrear_Enter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(809, 144);
            this.panelTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(274, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 78);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "PAGOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redondeoBtnCrear
            // 
            this.redondeoBtnCrear.ElipseRadius = 30;
            this.redondeoBtnCrear.TargetControl = this.panelCrear;
            // 
            // redondeoBtnBuscar
            // 
            this.redondeoBtnBuscar.ElipseRadius = 30;
            this.redondeoBtnBuscar.TargetControl = this;
            // 
            // FormOpcionesPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(809, 462);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionesPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesPagos";
            this.Load += new System.EventHandler(this.FormOpcionesPagos_Load);
            this.Shown += new System.EventHandler(this.FormOpcionesPagos_Shown);
            this.panelSubmenu.ResumeLayout(false);
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSubmenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblCrear;
        public System.Windows.Forms.Panel panelTitulo;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnCrear;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnBuscar;
        private System.Windows.Forms.Label lblTitulo;
    }
}