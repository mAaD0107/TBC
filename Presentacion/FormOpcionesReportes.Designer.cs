
namespace Presentacion
{
    partial class FormOpcionesReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesReportes));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelCarta = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblCarta = new System.Windows.Forms.Label();
            this.btnCarta = new System.Windows.Forms.Button();
            this.panelCuentasCobrar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblCuentaCobrar2 = new System.Windows.Forms.Label();
            this.btnCuentasCobrar = new System.Windows.Forms.Button();
            this.lblCuentaCobrar1 = new System.Windows.Forms.Label();
            this.redondeoCuentasCobrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoCarta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelCarta.SuspendLayout();
            this.panelCuentasCobrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1000, 172);
            this.panelTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(335, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelCarta);
            this.panelOpciones.Controls.Add(this.panelCuentasCobrar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1000, 278);
            this.panelOpciones.TabIndex = 3;
            // 
            // panelCarta
            // 
            this.panelCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCarta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCarta.BackgroundImage")));
            this.panelCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCarta.Controls.Add(this.lblCarta);
            this.panelCarta.Controls.Add(this.btnCarta);
            this.panelCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCarta.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCarta.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCarta.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCarta.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCarta.Location = new System.Drawing.Point(516, 55);
            this.panelCarta.Name = "panelCarta";
            this.panelCarta.Quality = 10;
            this.panelCarta.Size = new System.Drawing.Size(206, 179);
            this.panelCarta.TabIndex = 3;
            this.panelCarta.TabStop = true;
            this.panelCarta.Click += new System.EventHandler(this.panelCarta_Click);
            this.panelCarta.Enter += new System.EventHandler(this.panelCarta_MouseEnter);
            this.panelCarta.MouseEnter += new System.EventHandler(this.panelCarta_MouseEnter);
            // 
            // lblCarta
            // 
            this.lblCarta.AutoSize = true;
            this.lblCarta.BackColor = System.Drawing.Color.Transparent;
            this.lblCarta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCarta.Location = new System.Drawing.Point(59, 33);
            this.lblCarta.Name = "lblCarta";
            this.lblCarta.Size = new System.Drawing.Size(91, 33);
            this.lblCarta.TabIndex = 2;
            this.lblCarta.Text = "Carta";
            this.lblCarta.Click += new System.EventHandler(this.panelCarta_Click);
            this.lblCarta.Enter += new System.EventHandler(this.panelCarta_MouseEnter);
            this.lblCarta.MouseEnter += new System.EventHandler(this.panelCarta_MouseEnter);
            // 
            // btnCarta
            // 
            this.btnCarta.BackColor = System.Drawing.Color.Transparent;
            this.btnCarta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarta.BackgroundImage")));
            this.btnCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCarta.Location = new System.Drawing.Point(79, 107);
            this.btnCarta.Margin = new System.Windows.Forms.Padding(0);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(50, 50);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCarta.UseVisualStyleBackColor = false;
            this.btnCarta.Click += new System.EventHandler(this.panelCarta_Click);
            this.btnCarta.Enter += new System.EventHandler(this.panelCarta_MouseEnter);
            this.btnCarta.MouseEnter += new System.EventHandler(this.panelCarta_MouseEnter);
            // 
            // panelCuentasCobrar
            // 
            this.panelCuentasCobrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCuentasCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCuentasCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCuentasCobrar.BackgroundImage")));
            this.panelCuentasCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCuentasCobrar.Controls.Add(this.lblCuentaCobrar2);
            this.panelCuentasCobrar.Controls.Add(this.btnCuentasCobrar);
            this.panelCuentasCobrar.Controls.Add(this.lblCuentaCobrar1);
            this.panelCuentasCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCuentasCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCuentasCobrar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCuentasCobrar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCuentasCobrar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCuentasCobrar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCuentasCobrar.Location = new System.Drawing.Point(304, 55);
            this.panelCuentasCobrar.Name = "panelCuentasCobrar";
            this.panelCuentasCobrar.Quality = 10;
            this.panelCuentasCobrar.Size = new System.Drawing.Size(206, 179);
            this.panelCuentasCobrar.TabIndex = 2;
            this.panelCuentasCobrar.TabStop = true;
            this.panelCuentasCobrar.Click += new System.EventHandler(this.panelCuentasCobrar_Click);
            this.panelCuentasCobrar.MouseEnter += new System.EventHandler(this.panelCuentasCobrar_MouseEnter);
            // 
            // lblCuentaCobrar2
            // 
            this.lblCuentaCobrar2.AutoSize = true;
            this.lblCuentaCobrar2.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaCobrar2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaCobrar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCuentaCobrar2.Location = new System.Drawing.Point(51, 56);
            this.lblCuentaCobrar2.Name = "lblCuentaCobrar2";
            this.lblCuentaCobrar2.Size = new System.Drawing.Size(107, 33);
            this.lblCuentaCobrar2.TabIndex = 2;
            this.lblCuentaCobrar2.Text = "Cobrar";
            this.lblCuentaCobrar2.Click += new System.EventHandler(this.panelCuentasCobrar_Click);
            this.lblCuentaCobrar2.MouseEnter += new System.EventHandler(this.panelCuentasCobrar_MouseEnter);
            // 
            // btnCuentasCobrar
            // 
            this.btnCuentasCobrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCuentasCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuentasCobrar.BackgroundImage")));
            this.btnCuentasCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCuentasCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCuentasCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCuentasCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentasCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCuentasCobrar.Location = new System.Drawing.Point(79, 107);
            this.btnCuentasCobrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuentasCobrar.Name = "btnCuentasCobrar";
            this.btnCuentasCobrar.Size = new System.Drawing.Size(50, 50);
            this.btnCuentasCobrar.TabIndex = 0;
            this.btnCuentasCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCuentasCobrar.UseVisualStyleBackColor = false;
            this.btnCuentasCobrar.Click += new System.EventHandler(this.panelCuentasCobrar_Click);
            this.btnCuentasCobrar.MouseEnter += new System.EventHandler(this.panelCuentasCobrar_MouseEnter);
            // 
            // lblCuentaCobrar1
            // 
            this.lblCuentaCobrar1.AutoSize = true;
            this.lblCuentaCobrar1.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaCobrar1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaCobrar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCuentaCobrar1.Location = new System.Drawing.Point(16, 17);
            this.lblCuentaCobrar1.Name = "lblCuentaCobrar1";
            this.lblCuentaCobrar1.Size = new System.Drawing.Size(176, 33);
            this.lblCuentaCobrar1.TabIndex = 0;
            this.lblCuentaCobrar1.Text = "Cuentas por";
            this.lblCuentaCobrar1.Click += new System.EventHandler(this.panelCuentasCobrar_Click);
            this.lblCuentaCobrar1.MouseEnter += new System.EventHandler(this.panelCuentasCobrar_MouseEnter);
            // 
            // redondeoCuentasCobrar
            // 
            this.redondeoCuentasCobrar.ElipseRadius = 20;
            this.redondeoCuentasCobrar.TargetControl = this.panelCuentasCobrar;
            // 
            // redondeoCarta
            // 
            this.redondeoCarta.ElipseRadius = 20;
            this.redondeoCarta.TargetControl = this.panelCarta;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button1.Location = new System.Drawing.Point(132, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormOpcionesReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionesReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcionesTramite";
            this.Load += new System.EventHandler(this.FormOpcionesReportes_Load);
            this.Shown += new System.EventHandler(this.FormOpcionesReportes_Shown);
            this.Resize += new System.EventHandler(this.FormOpcionesReportes_Resize);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelCarta.ResumeLayout(false);
            this.panelCarta.PerformLayout();
            this.panelCuentasCobrar.ResumeLayout(false);
            this.panelCuentasCobrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCuentasCobrar;
        private System.Windows.Forms.Button btnCuentasCobrar;
        private System.Windows.Forms.Label lblCuentaCobrar1;
        private System.Windows.Forms.Label lblCuentaCobrar2;
        private Bunifu.Framework.UI.BunifuElipse redondeoCuentasCobrar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCarta;
        private System.Windows.Forms.Label lblCarta;
        private System.Windows.Forms.Button btnCarta;
        private Bunifu.Framework.UI.BunifuElipse redondeoCarta;
        private System.Windows.Forms.Button button1;
    }
}