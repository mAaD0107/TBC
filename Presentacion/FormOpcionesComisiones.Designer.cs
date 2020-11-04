namespace Presentacion
{
    partial class FormOpcionesComisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesComisiones));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelCrear = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCrear = new System.Windows.Forms.Label();
            this.panelBuscar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.redondeoCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBuscar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(809, 172);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.panelCrear);
            this.panelSubmenu.Controls.Add(this.panelBuscar);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 172);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(809, 290);
            this.panelSubmenu.TabIndex = 8;
            // 
            // panelCrear
            // 
            this.panelCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.panelCrear.Location = new System.Drawing.Point(157, 32);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Quality = 10;
            this.panelCrear.Size = new System.Drawing.Size(236, 207);
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
            this.btnCrear.Location = new System.Drawing.Point(86, 110);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 70);
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
            this.lblCrear.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCrear.Location = new System.Drawing.Point(61, 36);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(121, 44);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear";
            this.lblCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.lblCrear.Enter += new System.EventHandler(this.panelCrear_Enter);
            this.lblCrear.MouseEnter += new System.EventHandler(this.panelCrear_Enter);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscar.BackgroundImage")));
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscar.Controls.Add(this.lblEditar);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.lblBuscar);
            this.panelBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscar.Location = new System.Drawing.Point(428, 32);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Quality = 10;
            this.panelBuscar.Size = new System.Drawing.Size(236, 207);
            this.panelBuscar.TabIndex = 2;
            this.panelBuscar.Click += new System.EventHandler(this.panelBuscar_Click);
            this.panelBuscar.Enter += new System.EventHandler(this.panelBuscar_Enter);
            this.panelBuscar.MouseEnter += new System.EventHandler(this.panelBuscar_Enter);
            // 
            // lblEditar
            // 
            this.lblEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditar.AutoSize = true;
            this.lblEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblEditar.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblEditar.Location = new System.Drawing.Point(62, 56);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(115, 42);
            this.lblEditar.TabIndex = 3;
            this.lblEditar.Text = "Editar";
            this.lblEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditar.Click += new System.EventHandler(this.panelBuscar_Click);
            this.lblEditar.Enter += new System.EventHandler(this.panelBuscar_Enter);
            this.lblEditar.MouseEnter += new System.EventHandler(this.panelBuscar_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.Location = new System.Drawing.Point(84, 110);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 70);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.panelBuscar_Click);
            this.btnBuscar.Enter += new System.EventHandler(this.panelBuscar_Enter);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.panelBuscar_Enter);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblBuscar.Location = new System.Drawing.Point(54, 12);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(131, 42);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBuscar.Click += new System.EventHandler(this.panelBuscar_Click);
            this.lblBuscar.Enter += new System.EventHandler(this.panelBuscar_Enter);
            this.lblBuscar.MouseEnter += new System.EventHandler(this.panelBuscar_Enter);
            // 
            // redondeoCrear
            // 
            this.redondeoCrear.ElipseRadius = 30;
            this.redondeoCrear.TargetControl = this.panelCrear;
            // 
            // redondeoBuscar
            // 
            this.redondeoBuscar.ElipseRadius = 30;
            this.redondeoBuscar.TargetControl = this.panelBuscar;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(225, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 63);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "COMISIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOpcionesComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(809, 462);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionesComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesComisiones";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSubmenu.ResumeLayout(false);
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Panel panelSubmenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblCrear;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBuscar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private Bunifu.Framework.UI.BunifuElipse redondeoCrear;
        private Bunifu.Framework.UI.BunifuElipse redondeoBuscar;
        private System.Windows.Forms.Label lblTitulo;
    }
}