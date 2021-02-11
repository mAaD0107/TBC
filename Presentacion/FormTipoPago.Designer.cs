
namespace Presentacion
{
    partial class FormTipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoPago));
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelMultiple = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.lblMultiple = new System.Windows.Forms.Label();
            this.panelUnico = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnUnico = new System.Windows.Forms.Button();
            this.lblUnico = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.redondeoMultiple = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoUnico = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSubmenu.SuspendLayout();
            this.panelMultiple.SuspendLayout();
            this.panelUnico.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.panelMultiple);
            this.panelSubmenu.Controls.Add(this.panelUnico);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 144);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(793, 279);
            this.panelSubmenu.TabIndex = 11;
            // 
            // panelMultiple
            // 
            this.panelMultiple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelMultiple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMultiple.BackgroundImage")));
            this.panelMultiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMultiple.Controls.Add(this.btnMultiple);
            this.panelMultiple.Controls.Add(this.lblMultiple);
            this.panelMultiple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMultiple.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMultiple.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelMultiple.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMultiple.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelMultiple.Location = new System.Drawing.Point(398, 27);
            this.panelMultiple.Name = "panelMultiple";
            this.panelMultiple.Quality = 10;
            this.panelMultiple.Size = new System.Drawing.Size(206, 179);
            this.panelMultiple.TabIndex = 2;
            this.panelMultiple.Click += new System.EventHandler(this.panelMultiple_Click);
            this.panelMultiple.Enter += new System.EventHandler(this.panelMultiple_Enter);
            this.panelMultiple.MouseEnter += new System.EventHandler(this.panelMultiple_Enter);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnMultiple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultiple.BackgroundImage")));
            this.btnMultiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMultiple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnMultiple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnMultiple.Location = new System.Drawing.Point(82, 99);
            this.btnMultiple.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(50, 50);
            this.btnMultiple.TabIndex = 2;
            this.btnMultiple.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.panelMultiple_Click);
            this.btnMultiple.Enter += new System.EventHandler(this.panelMultiple_Enter);
            this.btnMultiple.MouseEnter += new System.EventHandler(this.panelMultiple_Enter);
            // 
            // lblMultiple
            // 
            this.lblMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMultiple.AutoSize = true;
            this.lblMultiple.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiple.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblMultiple.Location = new System.Drawing.Point(47, 36);
            this.lblMultiple.Name = "lblMultiple";
            this.lblMultiple.Size = new System.Drawing.Size(120, 33);
            this.lblMultiple.TabIndex = 0;
            this.lblMultiple.Text = "Múltiple";
            this.lblMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMultiple.Click += new System.EventHandler(this.panelMultiple_Click);
            this.lblMultiple.Enter += new System.EventHandler(this.panelMultiple_Enter);
            this.lblMultiple.MouseEnter += new System.EventHandler(this.panelMultiple_Enter);
            // 
            // panelUnico
            // 
            this.panelUnico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelUnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUnico.BackgroundImage")));
            this.panelUnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUnico.Controls.Add(this.btnUnico);
            this.panelUnico.Controls.Add(this.lblUnico);
            this.panelUnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUnico.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelUnico.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelUnico.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelUnico.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelUnico.Location = new System.Drawing.Point(186, 27);
            this.panelUnico.Name = "panelUnico";
            this.panelUnico.Quality = 10;
            this.panelUnico.Size = new System.Drawing.Size(206, 179);
            this.panelUnico.TabIndex = 1;
            this.panelUnico.Click += new System.EventHandler(this.panelUnico_Click);
            this.panelUnico.Enter += new System.EventHandler(this.panelUnico_Enter);
            this.panelUnico.MouseEnter += new System.EventHandler(this.panelUnico_Enter);
            // 
            // btnUnico
            // 
            this.btnUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnUnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnico.BackgroundImage")));
            this.btnUnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnUnico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnUnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnUnico.Location = new System.Drawing.Point(81, 99);
            this.btnUnico.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnico.Name = "btnUnico";
            this.btnUnico.Size = new System.Drawing.Size(50, 50);
            this.btnUnico.TabIndex = 1;
            this.btnUnico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUnico.UseVisualStyleBackColor = false;
            this.btnUnico.Click += new System.EventHandler(this.panelUnico_Click);
            this.btnUnico.Enter += new System.EventHandler(this.panelUnico_Enter);
            this.btnUnico.MouseEnter += new System.EventHandler(this.panelUnico_Enter);
            // 
            // lblUnico
            // 
            this.lblUnico.AutoSize = true;
            this.lblUnico.BackColor = System.Drawing.Color.Transparent;
            this.lblUnico.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblUnico.Location = new System.Drawing.Point(62, 36);
            this.lblUnico.Name = "lblUnico";
            this.lblUnico.Size = new System.Drawing.Size(89, 33);
            this.lblUnico.TabIndex = 0;
            this.lblUnico.Text = "Único";
            this.lblUnico.Click += new System.EventHandler(this.panelUnico_Click);
            this.lblUnico.Enter += new System.EventHandler(this.panelUnico_Enter);
            this.lblUnico.MouseEnter += new System.EventHandler(this.panelUnico_Enter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(793, 144);
            this.panelTitulo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(282, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 78);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "PAGO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redondeoMultiple
            // 
            this.redondeoMultiple.ElipseRadius = 20;
            this.redondeoMultiple.TargetControl = this.panelMultiple;
            // 
            // redondeoUnico
            // 
            this.redondeoUnico.ElipseRadius = 20;
            this.redondeoUnico.TargetControl = this.panelUnico;
            // 
            // FormTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(793, 423);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTipoPago";
            this.Text = "TipoPago";
            this.panelSubmenu.ResumeLayout(false);
            this.panelMultiple.ResumeLayout(false);
            this.panelMultiple.PerformLayout();
            this.panelUnico.ResumeLayout(false);
            this.panelUnico.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSubmenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMultiple;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Label lblMultiple;
        private Bunifu.Framework.UI.BunifuGradientPanel panelUnico;
        private System.Windows.Forms.Button btnUnico;
        private System.Windows.Forms.Label lblUnico;
        public System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse redondeoMultiple;
        private Bunifu.Framework.UI.BunifuElipse redondeoUnico;
    }
}