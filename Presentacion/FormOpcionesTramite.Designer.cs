namespace Presentacion
{
    partial class FormOpcionesTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesTramite));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelDocumentos = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.lblDocumentos = new System.Windows.Forms.Label();
            this.panelBuscar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelAgregarInfo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblAgregarInfo = new System.Windows.Forms.Label();
            this.btnAgregarInfo = new System.Windows.Forms.Button();
            this.panelCrear = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCrear = new System.Windows.Forms.Label();
            this.redondeoCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoAgregarInfo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBuscar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoDocumentos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelDocumentos.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelAgregarInfo.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnAtras);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1000, 172);
            this.panelTitulo.TabIndex = 1;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnAtras.Location = new System.Drawing.Point(112, 67);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(30, 30);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 39.75F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(372, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 63);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TRÁMITES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelDocumentos);
            this.panelOpciones.Controls.Add(this.panelBuscar);
            this.panelOpciones.Controls.Add(this.panelAgregarInfo);
            this.panelOpciones.Controls.Add(this.panelCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1000, 278);
            this.panelOpciones.TabIndex = 2;
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDocumentos.BackgroundImage")));
            this.panelDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDocumentos.Controls.Add(this.btnDocumentos);
            this.panelDocumentos.Controls.Add(this.lblDocumentos);
            this.panelDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDocumentos.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelDocumentos.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelDocumentos.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelDocumentos.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelDocumentos.Location = new System.Drawing.Point(718, 50);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Quality = 10;
            this.panelDocumentos.Size = new System.Drawing.Size(192, 179);
            this.panelDocumentos.TabIndex = 5;
            this.panelDocumentos.TabStop = true;
            this.panelDocumentos.Enter += new System.EventHandler(this.pnlEditarTramite_Enter);
            this.panelDocumentos.MouseEnter += new System.EventHandler(this.pnlEditarTramite_Enter);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocumentos.BackgroundImage")));
            this.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocumentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDocumentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDocumentos.Location = new System.Drawing.Point(73, 97);
            this.btnDocumentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(50, 50);
            this.btnDocumentos.TabIndex = 0;
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Enter += new System.EventHandler(this.pnlEditarTramite_Enter);
            this.btnDocumentos.MouseEnter += new System.EventHandler(this.pnlEditarTramite_Enter);
            // 
            // lblDocumentos
            // 
            this.lblDocumentos.AutoSize = true;
            this.lblDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentos.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblDocumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblDocumentos.Location = new System.Drawing.Point(-1, 31);
            this.lblDocumentos.Name = "lblDocumentos";
            this.lblDocumentos.Size = new System.Drawing.Size(198, 36);
            this.lblDocumentos.TabIndex = 0;
            this.lblDocumentos.Text = "Documentos";
            this.lblDocumentos.Enter += new System.EventHandler(this.pnlEditarTramite_Enter);
            this.lblDocumentos.MouseEnter += new System.EventHandler(this.pnlEditarTramite_Enter);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscar.BackgroundImage")));
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.lblBuscar);
            this.panelBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscar.Location = new System.Drawing.Point(511, 50);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Quality = 10;
            this.panelBuscar.Size = new System.Drawing.Size(192, 179);
            this.panelBuscar.TabIndex = 4;
            this.panelBuscar.TabStop = true;
            this.panelBuscar.Click += new System.EventHandler(this.pnlBuscar_Click);
            this.panelBuscar.Enter += new System.EventHandler(this.pnlBuscar_Enter);
            this.panelBuscar.MouseEnter += new System.EventHandler(this.pnlBuscar_Enter);
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
            this.btnBuscar.Location = new System.Drawing.Point(75, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.pnlBuscar_Click);
            this.btnBuscar.Enter += new System.EventHandler(this.pnlBuscar_Enter);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.pnlBuscar_Enter);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblBuscar.Location = new System.Drawing.Point(46, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(109, 36);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.pnlBuscar_Click);
            this.lblBuscar.Enter += new System.EventHandler(this.pnlBuscar_Enter);
            this.lblBuscar.MouseEnter += new System.EventHandler(this.pnlBuscar_Enter);
            // 
            // panelAgregarInfo
            // 
            this.panelAgregarInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAgregarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelAgregarInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAgregarInfo.BackgroundImage")));
            this.panelAgregarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAgregarInfo.Controls.Add(this.lblAgregarInfo);
            this.panelAgregarInfo.Controls.Add(this.btnAgregarInfo);
            this.panelAgregarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAgregarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAgregarInfo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelAgregarInfo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelAgregarInfo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelAgregarInfo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelAgregarInfo.Location = new System.Drawing.Point(304, 50);
            this.panelAgregarInfo.Name = "panelAgregarInfo";
            this.panelAgregarInfo.Quality = 10;
            this.panelAgregarInfo.Size = new System.Drawing.Size(192, 179);
            this.panelAgregarInfo.TabIndex = 3;
            this.panelAgregarInfo.TabStop = true;
            this.panelAgregarInfo.Click += new System.EventHandler(this.lblAgregarInfo_Click);
            this.panelAgregarInfo.Enter += new System.EventHandler(this.lblAgregarInfo_Enter);
            this.panelAgregarInfo.MouseEnter += new System.EventHandler(this.lblAgregarInfo_Enter);
            // 
            // lblAgregarInfo
            // 
            this.lblAgregarInfo.AutoSize = true;
            this.lblAgregarInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarInfo.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblAgregarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblAgregarInfo.Location = new System.Drawing.Point(33, 19);
            this.lblAgregarInfo.Name = "lblAgregarInfo";
            this.lblAgregarInfo.Size = new System.Drawing.Size(141, 72);
            this.lblAgregarInfo.TabIndex = 0;
            this.lblAgregarInfo.Text = "Agregar \r\n    Info";
            this.lblAgregarInfo.Click += new System.EventHandler(this.lblAgregarInfo_Click);
            this.lblAgregarInfo.Enter += new System.EventHandler(this.lblAgregarInfo_Enter);
            this.lblAgregarInfo.MouseEnter += new System.EventHandler(this.lblAgregarInfo_Enter);
            // 
            // btnAgregarInfo
            // 
            this.btnAgregarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAgregarInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarInfo.BackgroundImage")));
            this.btnAgregarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAgregarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAgregarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAgregarInfo.Location = new System.Drawing.Point(71, 97);
            this.btnAgregarInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarInfo.Name = "btnAgregarInfo";
            this.btnAgregarInfo.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarInfo.TabIndex = 0;
            this.btnAgregarInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarInfo.UseVisualStyleBackColor = false;
            this.btnAgregarInfo.Click += new System.EventHandler(this.lblAgregarInfo_Click);
            this.btnAgregarInfo.Enter += new System.EventHandler(this.lblAgregarInfo_Enter);
            this.btnAgregarInfo.MouseEnter += new System.EventHandler(this.lblAgregarInfo_Enter);
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
            this.panelCrear.Location = new System.Drawing.Point(97, 50);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Quality = 10;
            this.panelCrear.Size = new System.Drawing.Size(192, 179);
            this.panelCrear.TabIndex = 2;
            this.panelCrear.TabStop = true;
            this.panelCrear.Click += new System.EventHandler(this.panelCrearTramite_Click);
            this.panelCrear.Enter += new System.EventHandler(this.panelCrearTramite_Enter);
            this.panelCrear.MouseEnter += new System.EventHandler(this.panelCrearTramite_Enter);
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
            this.btnCrear.Location = new System.Drawing.Point(73, 97);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(50, 50);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.panelCrearTramite_Click);
            this.btnCrear.Enter += new System.EventHandler(this.panelCrearTramite_Enter);
            this.btnCrear.MouseEnter += new System.EventHandler(this.panelCrearTramite_Enter);
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCrear.Location = new System.Drawing.Point(50, 31);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(96, 36);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear";
            this.lblCrear.Click += new System.EventHandler(this.panelCrearTramite_Click);
            this.lblCrear.Enter += new System.EventHandler(this.panelCrearTramite_Enter);
            this.lblCrear.MouseEnter += new System.EventHandler(this.panelCrearTramite_Enter);
            // 
            // redondeoCrear
            // 
            this.redondeoCrear.ElipseRadius = 30;
            this.redondeoCrear.TargetControl = this.panelCrear;
            // 
            // redondeoAgregarInfo
            // 
            this.redondeoAgregarInfo.ElipseRadius = 30;
            this.redondeoAgregarInfo.TargetControl = this.panelAgregarInfo;
            // 
            // redondeoBuscar
            // 
            this.redondeoBuscar.ElipseRadius = 30;
            this.redondeoBuscar.TargetControl = this.panelBuscar;
            // 
            // redondeoDocumentos
            // 
            this.redondeoDocumentos.ElipseRadius = 30;
            this.redondeoDocumentos.TargetControl = this.panelDocumentos;
            // 
            // FormOpcionesTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormOpcionesTramite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesTramite";
            this.Load += new System.EventHandler(this.FormOpcionesTramite_Load);
            this.Shown += new System.EventHandler(this.FormOpcionesTramite_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOpcionesTramite_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelDocumentos.ResumeLayout(false);
            this.panelDocumentos.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelAgregarInfo.ResumeLayout(false);
            this.panelAgregarInfo.PerformLayout();
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label lblDocumentos;
        private Bunifu.Framework.UI.BunifuElipse redondeoCrear;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblAgregarInfo;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCrear;
        private System.Windows.Forms.Button btnCrear;
        private Bunifu.Framework.UI.BunifuGradientPanel panelDocumentos;
        private System.Windows.Forms.Button btnDocumentos;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelAgregarInfo;
        private System.Windows.Forms.Button btnAgregarInfo;
        private Bunifu.Framework.UI.BunifuElipse redondeoAgregarInfo;
        private Bunifu.Framework.UI.BunifuElipse redondeoBuscar;
        private Bunifu.Framework.UI.BunifuElipse redondeoDocumentos;
    }
}