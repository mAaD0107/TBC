namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnOtrosServicios = new System.Windows.Forms.Button();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnExportaciones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnImportaciones = new System.Windows.Forms.Button();
            this.btnTramites = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.animacionPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.PanelSubContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.redondeoPanelInferior = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoFormPrincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelGlobal.SuspendLayout();
            this.PanelSubContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.imgLogo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.animacionPanel.SetDecoration(this.panelTitulo, BunifuAnimatorNS.DecorationType.None);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 30);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDoubleClick);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.animacionPanel.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1277, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.animacionPanel.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1254, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.animacionPanel.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1231, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.animacionPanel.SetDecoration(this.imgLogo, BunifuAnimatorNS.DecorationType.None);
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(7, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(20, 20);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.animacionPanel.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lblTitulo.Location = new System.Drawing.Point(29, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TBC";
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelMenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuVertical.Controls.Add(this.btnOtrosServicios);
            this.panelMenuVertical.Controls.Add(this.btnRecaudacion);
            this.panelMenuVertical.Controls.Add(this.btnConfigurar);
            this.panelMenuVertical.Controls.Add(this.btnLogOut);
            this.panelMenuVertical.Controls.Add(this.btnInicio);
            this.panelMenuVertical.Controls.Add(this.btnExportaciones);
            this.panelMenuVertical.Controls.Add(this.btnReportes);
            this.panelMenuVertical.Controls.Add(this.btnImportaciones);
            this.panelMenuVertical.Controls.Add(this.btnTramites);
            this.panelMenuVertical.Controls.Add(this.btnClientes);
            this.animacionPanel.SetDecoration(this.panelMenuVertical, BunifuAnimatorNS.DecorationType.None);
            this.panelMenuVertical.Location = new System.Drawing.Point(3, 3);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 614);
            this.panelMenuVertical.TabIndex = 0;
            // 
            // btnOtrosServicios
            // 
            this.animacionPanel.SetDecoration(this.btnOtrosServicios, BunifuAnimatorNS.DecorationType.None);
            this.btnOtrosServicios.FlatAppearance.BorderSize = 0;
            this.btnOtrosServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnOtrosServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtrosServicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtrosServicios.ForeColor = System.Drawing.Color.Transparent;
            this.btnOtrosServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnOtrosServicios.Image")));
            this.btnOtrosServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtrosServicios.Location = new System.Drawing.Point(0, 290);
            this.btnOtrosServicios.Name = "btnOtrosServicios";
            this.btnOtrosServicios.Size = new System.Drawing.Size(250, 45);
            this.btnOtrosServicios.TabIndex = 9;
            this.btnOtrosServicios.Text = "   Otros Servicios";
            this.btnOtrosServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtrosServicios.UseVisualStyleBackColor = true;
            this.btnOtrosServicios.Click += new System.EventHandler(this.btnOtrosServicios_Click);
            // 
            // btnRecaudacion
            // 
            this.animacionPanel.SetDecoration(this.btnRecaudacion, BunifuAnimatorNS.DecorationType.None);
            this.btnRecaudacion.FlatAppearance.BorderSize = 0;
            this.btnRecaudacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnRecaudacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecaudacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecaudacion.Image = ((System.Drawing.Image)(resources.GetObject("btnRecaudacion.Image")));
            this.btnRecaudacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecaudacion.Location = new System.Drawing.Point(0, 341);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(250, 45);
            this.btnRecaudacion.TabIndex = 6;
            this.btnRecaudacion.Text = "   Recaudación";
            this.btnRecaudacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animacionPanel.SetDecoration(this.btnConfigurar, BunifuAnimatorNS.DecorationType.None);
            this.btnConfigurar.FlatAppearance.BorderSize = 0;
            this.btnConfigurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.Image")));
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.Location = new System.Drawing.Point(0, 517);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(250, 45);
            this.btnConfigurar.TabIndex = 7;
            this.btnConfigurar.Text = "   Configurar";
            this.btnConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animacionPanel.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 566);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "   Cerrar Sesión";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnInicio
            // 
            this.animacionPanel.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 20);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(250, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "  DASHBOARD";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnExportaciones
            // 
            this.animacionPanel.SetDecoration(this.btnExportaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnExportaciones.FlatAppearance.BorderSize = 0;
            this.btnExportaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnExportaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportaciones.ForeColor = System.Drawing.Color.Transparent;
            this.btnExportaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnExportaciones.Image")));
            this.btnExportaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportaciones.Location = new System.Drawing.Point(0, 239);
            this.btnExportaciones.Name = "btnExportaciones";
            this.btnExportaciones.Size = new System.Drawing.Size(250, 45);
            this.btnExportaciones.TabIndex = 4;
            this.btnExportaciones.Text = "   Exportaciones";
            this.btnExportaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportaciones.UseVisualStyleBackColor = true;
            this.btnExportaciones.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReportes
            // 
            this.animacionPanel.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 390);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 45);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "   Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnImportaciones
            // 
            this.animacionPanel.SetDecoration(this.btnImportaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnImportaciones.FlatAppearance.BorderSize = 0;
            this.btnImportaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnImportaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportaciones.ForeColor = System.Drawing.Color.Transparent;
            this.btnImportaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnImportaciones.Image")));
            this.btnImportaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportaciones.Location = new System.Drawing.Point(0, 190);
            this.btnImportaciones.Name = "btnImportaciones";
            this.btnImportaciones.Size = new System.Drawing.Size(250, 45);
            this.btnImportaciones.TabIndex = 3;
            this.btnImportaciones.Text = "   Importaciones";
            this.btnImportaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportaciones.UseVisualStyleBackColor = true;
            this.btnImportaciones.Click += new System.EventHandler(this.btnImportaciones_Click);
            // 
            // btnTramites
            // 
            this.animacionPanel.SetDecoration(this.btnTramites, BunifuAnimatorNS.DecorationType.None);
            this.btnTramites.FlatAppearance.BorderSize = 0;
            this.btnTramites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnTramites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramites.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTramites.ForeColor = System.Drawing.Color.Transparent;
            this.btnTramites.Image = ((System.Drawing.Image)(resources.GetObject("btnTramites.Image")));
            this.btnTramites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTramites.Location = new System.Drawing.Point(0, 141);
            this.btnTramites.Name = "btnTramites";
            this.btnTramites.Size = new System.Drawing.Size(250, 45);
            this.btnTramites.TabIndex = 2;
            this.btnTramites.Text = "   Proveedores";
            this.btnTramites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTramites.UseVisualStyleBackColor = true;
            this.btnTramites.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.animacionPanel.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 92);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 45);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseCompatibleTextRendering = true;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelInferior.Controls.Add(this.lblFecha);
            this.panelInferior.Controls.Add(this.lblEmail);
            this.panelInferior.Controls.Add(this.lblCargo);
            this.panelInferior.Controls.Add(this.lblUsuario);
            this.panelInferior.Controls.Add(this.pictureBox2);
            this.animacionPanel.SetDecoration(this.panelInferior, BunifuAnimatorNS.DecorationType.None);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInferior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelInferior.Location = new System.Drawing.Point(3, 517);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1032, 94);
            this.panelInferior.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.animacionPanel.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.lblFecha.Location = new System.Drawing.Point(610, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(422, 94);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "03 de Septiembre del 2020";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.animacionPanel.SetDecoration(this.lblEmail, BunifuAnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.lblEmail.Location = new System.Drawing.Point(105, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.animacionPanel.SetDecoration(this.lblCargo, BunifuAnimatorNS.DecorationType.None);
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.lblCargo.Location = new System.Drawing.Point(105, 41);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.animacionPanel.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.lblUsuario.Location = new System.Drawing.Point(105, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.animacionPanel.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // animacionPanel
            // 
            this.animacionPanel.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animacionPanel.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animacionPanel.DefaultAnimation = animation2;
            this.animacionPanel.Interval = 2;
            // 
            // panelGlobal
            // 
            this.panelGlobal.ColumnCount = 2;
            this.panelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.76923F));
            this.panelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.23077F));
            this.panelGlobal.Controls.Add(this.panelMenuVertical, 0, 0);
            this.panelGlobal.Controls.Add(this.PanelSubContenedor, 1, 0);
            this.animacionPanel.SetDecoration(this.panelGlobal, BunifuAnimatorNS.DecorationType.None);
            this.panelGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGlobal.Location = new System.Drawing.Point(0, 30);
            this.panelGlobal.Name = "panelGlobal";
            this.panelGlobal.RowCount = 1;
            this.panelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelGlobal.Size = new System.Drawing.Size(1300, 620);
            this.panelGlobal.TabIndex = 4;
            // 
            // PanelSubContenedor
            // 
            this.PanelSubContenedor.ColumnCount = 1;
            this.PanelSubContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelSubContenedor.Controls.Add(this.panelContenedor, 0, 0);
            this.PanelSubContenedor.Controls.Add(this.panelInferior, 0, 1);
            this.animacionPanel.SetDecoration(this.PanelSubContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelSubContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSubContenedor.Location = new System.Drawing.Point(259, 3);
            this.PanelSubContenedor.Name = "PanelSubContenedor";
            this.PanelSubContenedor.RowCount = 2;
            this.PanelSubContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.87622F));
            this.PanelSubContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12378F));
            this.PanelSubContenedor.Size = new System.Drawing.Size(1038, 614);
            this.PanelSubContenedor.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animacionPanel.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(3, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1032, 508);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // redondeoPanelInferior
            // 
            this.redondeoPanelInferior.ElipseRadius = 10;
            this.redondeoPanelInferior.TargetControl = this.panelInferior;
            // 
            // redondeoFormPrincipal
            // 
            this.redondeoFormPrincipal.ElipseRadius = 20;
            this.redondeoFormPrincipal.TargetControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelGlobal);
            this.Controls.Add(this.panelTitulo);
            this.animacionPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Best Cargo";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelGlobal.ResumeLayout(false);
            this.PanelSubContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnImportaciones;
        private System.Windows.Forms.Button btnTramites;
        private System.Windows.Forms.Button btnExportaciones;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFecha;
        private BunifuAnimatorNS.BunifuTransition animacionPanel;
        public System.Windows.Forms.Panel panelMenuVertical;
        private Bunifu.Framework.UI.BunifuElipse redondeoPanelInferior;
        public System.Windows.Forms.TableLayoutPanel panelGlobal;
        private System.Windows.Forms.Button btnRecaudacion;
        public System.Windows.Forms.Panel panelInferior;
        public System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.TableLayoutPanel PanelSubContenedor;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.PictureBox imgLogo;
        public System.Windows.Forms.Panel panelTitulo;
        private Bunifu.Framework.UI.BunifuElipse redondeoFormPrincipal;
        private System.Windows.Forms.Button btnOtrosServicios;
    }
}

