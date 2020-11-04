namespace Presentacion
{
    partial class FormOpcionesFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesFactura));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelBuscarFactura = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pnlEditarFactura = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEditar = new System.Windows.Forms.Label();
            this.panelCrearFactura = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCrear = new System.Windows.Forms.Label();
            this.redondeoCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBuscar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoEditar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelBuscarFactura.SuspendLayout();
            this.pnlEditarFactura.SuspendLayout();
            this.panelCrearFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 172);
            this.panelTitulo.TabIndex = 4;
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
            this.button1.Location = new System.Drawing.Point(112, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(228, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(344, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FACTURAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelBuscarFactura);
            this.panelOpciones.Controls.Add(this.pnlEditarFactura);
            this.panelOpciones.Controls.Add(this.panelCrearFactura);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(800, 278);
            this.panelOpciones.TabIndex = 3;
            // 
            // panelBuscarFactura
            // 
            this.panelBuscarFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscarFactura.BackgroundImage")));
            this.panelBuscarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscarFactura.Controls.Add(this.btnBuscar);
            this.panelBuscarFactura.Controls.Add(this.lblBuscar);
            this.panelBuscarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscarFactura.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarFactura.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscarFactura.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarFactura.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscarFactura.Location = new System.Drawing.Point(282, 43);
            this.panelBuscarFactura.Name = "panelBuscarFactura";
            this.panelBuscarFactura.Quality = 10;
            this.panelBuscarFactura.Size = new System.Drawing.Size(236, 207);
            this.panelBuscarFactura.TabIndex = 2;
            this.panelBuscarFactura.Enter += new System.EventHandler(this.pnlBuscar_MouseEnter);
            this.panelBuscarFactura.Leave += new System.EventHandler(this.pnlBuscar_MouseLeave);
            this.panelBuscarFactura.MouseEnter += new System.EventHandler(this.pnlBuscar_MouseEnter);
            this.panelBuscarFactura.MouseLeave += new System.EventHandler(this.pnlBuscar_MouseLeave);
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
            this.btnBuscar.Location = new System.Drawing.Point(94, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 70);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblBuscar.Location = new System.Drawing.Point(59, 39);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(138, 44);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.MouseEnter += new System.EventHandler(this.pnlBuscar_MouseEnter);
            this.lblBuscar.MouseLeave += new System.EventHandler(this.pnlBuscar_MouseLeave);
            // 
            // pnlEditarFactura
            // 
            this.pnlEditarFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlEditarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlEditarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEditarFactura.BackgroundImage")));
            this.pnlEditarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEditarFactura.Controls.Add(this.btnEditar);
            this.pnlEditarFactura.Controls.Add(this.lblEditar);
            this.pnlEditarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEditarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEditarFactura.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlEditarFactura.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.pnlEditarFactura.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlEditarFactura.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.pnlEditarFactura.Location = new System.Drawing.Point(552, 43);
            this.pnlEditarFactura.Name = "pnlEditarFactura";
            this.pnlEditarFactura.Quality = 10;
            this.pnlEditarFactura.Size = new System.Drawing.Size(236, 207);
            this.pnlEditarFactura.TabIndex = 3;
            this.pnlEditarFactura.Enter += new System.EventHandler(this.pnlEditarTramite_MouseEnter);
            this.pnlEditarFactura.Leave += new System.EventHandler(this.pnlEditarTramite_MouseLeave);
            this.pnlEditarFactura.MouseEnter += new System.EventHandler(this.pnlEditarTramite_MouseEnter);
            this.pnlEditarFactura.MouseLeave += new System.EventHandler(this.pnlEditarTramite_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.Location = new System.Drawing.Point(81, 103);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 70);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblEditar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblEditar.Location = new System.Drawing.Point(58, 39);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(120, 44);
            this.lblEditar.TabIndex = 0;
            this.lblEditar.Text = "Editar";
            this.lblEditar.MouseEnter += new System.EventHandler(this.pnlEditarTramite_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pnlEditarTramite_MouseLeave);
            // 
            // panelCrearFactura
            // 
            this.panelCrearFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrearFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCrearFactura.BackgroundImage")));
            this.panelCrearFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCrearFactura.Controls.Add(this.btnCrear);
            this.panelCrearFactura.Controls.Add(this.lblCrear);
            this.panelCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCrearFactura.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrearFactura.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrearFactura.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrearFactura.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrearFactura.Location = new System.Drawing.Point(12, 43);
            this.panelCrearFactura.Name = "panelCrearFactura";
            this.panelCrearFactura.Quality = 10;
            this.panelCrearFactura.Size = new System.Drawing.Size(236, 207);
            this.panelCrearFactura.TabIndex = 1;
            this.panelCrearFactura.Click += new System.EventHandler(this.panelCrearTramite_Click);
            this.panelCrearFactura.Enter += new System.EventHandler(this.panelCrearTramite_MouseEnter);
            this.panelCrearFactura.Leave += new System.EventHandler(this.panelCrearTramite_MouseLeave);
            this.panelCrearFactura.MouseEnter += new System.EventHandler(this.panelCrearTramite_MouseEnter);
            this.panelCrearFactura.MouseLeave += new System.EventHandler(this.panelCrearTramite_MouseLeave);
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
            this.btnCrear.Location = new System.Drawing.Point(88, 103);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 70);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.panelCrearTramite_Click);
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCrear.Location = new System.Drawing.Point(59, 39);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(121, 44);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear";
            this.lblCrear.Click += new System.EventHandler(this.panelCrearTramite_Click);
            this.lblCrear.MouseEnter += new System.EventHandler(this.panelCrearTramite_MouseEnter);
            this.lblCrear.MouseLeave += new System.EventHandler(this.panelCrearTramite_MouseLeave);
            // 
            // redondeoCrear
            // 
            this.redondeoCrear.ElipseRadius = 30;
            this.redondeoCrear.TargetControl = this.panelCrearFactura;
            // 
            // redondeoBuscar
            // 
            this.redondeoBuscar.ElipseRadius = 30;
            this.redondeoBuscar.TargetControl = this.panelBuscarFactura;
            // 
            // redondeoEditar
            // 
            this.redondeoEditar.ElipseRadius = 30;
            this.redondeoEditar.TargetControl = this.pnlEditarFactura;
            // 
            // FormOpcionesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormOpcionesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesFactura";
            this.Shown += new System.EventHandler(this.FormOpcionesFactura_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOpcionesFactura_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelBuscarFactura.ResumeLayout(false);
            this.panelBuscarFactura.PerformLayout();
            this.pnlEditarFactura.ResumeLayout(false);
            this.pnlEditarFactura.PerformLayout();
            this.panelCrearFactura.ResumeLayout(false);
            this.panelCrearFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBuscarFactura;
        private System.Windows.Forms.Label lblBuscar;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEditarFactura;
        private System.Windows.Forms.Label lblEditar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCrearFactura;
        private System.Windows.Forms.Label lblCrear;
        private Bunifu.Framework.UI.BunifuElipse redondeoCrear;
        private Bunifu.Framework.UI.BunifuElipse redondeoBuscar;
        private Bunifu.Framework.UI.BunifuElipse redondeoEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button1;
    }
}