namespace Presentacion
{
    partial class FormPreCrearComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreCrearComision));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Label();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panelGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTituloFiltro = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCiudadNacionalizacion = new System.Windows.Forms.ComboBox();
            this.dateFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape42 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridTramites = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.redondeoBtnCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelTituloFiltro.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPropiedades
            // 
            this.panelPropiedades.Controls.Add(this.cerrar);
            this.panelPropiedades.Controls.Add(this.maximizar);
            this.panelPropiedades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPropiedades.Location = new System.Drawing.Point(0, 0);
            this.panelPropiedades.Name = "panelPropiedades";
            this.panelPropiedades.Size = new System.Drawing.Size(1050, 37);
            this.panelPropiedades.TabIndex = 1;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.cerrar.Location = new System.Drawing.Point(1011, 7);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(17, 16);
            this.cerrar.TabIndex = 7;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(990, 8);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(15, 15);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 8;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.AutoScroll = true;
            this.panelGeneral.Controls.Add(this.panelTitulo);
            this.panelGeneral.Controls.Add(this.panelTituloFiltro);
            this.panelGeneral.Controls.Add(this.panelFiltros);
            this.panelGeneral.Controls.Add(this.panelDatos);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 37);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1050, 743);
            this.panelGeneral.TabIndex = 2;
            this.panelGeneral.Resize += new System.EventHandler(this.panelGeneral_Resize);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1008, 81);
            this.panelTitulo.TabIndex = 34;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(347, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 56);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "COMISIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTituloFiltro
            // 
            this.panelTituloFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloFiltro.Controls.Add(this.label36);
            this.panelTituloFiltro.Location = new System.Drawing.Point(3, 90);
            this.panelTituloFiltro.Name = "panelTituloFiltro";
            this.panelTituloFiltro.Size = new System.Drawing.Size(1008, 104);
            this.panelTituloFiltro.TabIndex = 36;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.label36.Location = new System.Drawing.Point(20, 38);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(164, 36);
            this.label36.TabIndex = 58;
            this.label36.Text = "Buscar por";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.cmbTipoDocumento);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.cmbCiudadNacionalizacion);
            this.panelFiltros.Controls.Add(this.dateFin);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.dateInicio);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.lblEmpresa);
            this.panelFiltros.Controls.Add(this.shapeContainer2);
            this.panelFiltros.Location = new System.Drawing.Point(3, 200);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1008, 217);
            this.panelFiltros.TabIndex = 37;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.Transparent;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Factura",
            "Nota de Venta"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(230, 175);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(149, 25);
            this.cmbTipoDocumento.TabIndex = 58;
            this.cmbTipoDocumento.TextChanged += new System.EventHandler(this.cmbTipoDocumento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tipo de Documento a Crear:";
            // 
            // cmbCiudadNacionalizacion
            // 
            this.cmbCiudadNacionalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cmbCiudadNacionalizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadNacionalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCiudadNacionalizacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudadNacionalizacion.ForeColor = System.Drawing.Color.Transparent;
            this.cmbCiudadNacionalizacion.FormattingEnabled = true;
            this.cmbCiudadNacionalizacion.Items.AddRange(new object[] {
            "Todas",
            "Quito",
            "Guayaquil",
            "Tulcán",
            "Huaquillas"});
            this.cmbCiudadNacionalizacion.Location = new System.Drawing.Point(215, 108);
            this.cmbCiudadNacionalizacion.Name = "cmbCiudadNacionalizacion";
            this.cmbCiudadNacionalizacion.Size = new System.Drawing.Size(234, 25);
            this.cmbCiudadNacionalizacion.TabIndex = 56;
            this.cmbCiudadNacionalizacion.TextChanged += new System.EventHandler(this.cmbCiudadNacionalizacion_TextChanged);
            // 
            // dateFin
            // 
            this.dateFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dateFin.BorderRadius = 0;
            this.dateFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.ForeColor = System.Drawing.Color.DimGray;
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFin.FormatCustom = null;
            this.dateFin.Location = new System.Drawing.Point(574, 31);
            this.dateFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(394, 44);
            this.dateFin.TabIndex = 55;
            this.dateFin.Value = new System.DateTime(2020, 9, 15, 10, 48, 13, 902);
            this.dateFin.onValueChanged += new System.EventHandler(this.dateFin_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(552, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "a";
            // 
            // dateInicio
            // 
            this.dateInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dateInicio.BorderRadius = 0;
            this.dateInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicio.ForeColor = System.Drawing.Color.DimGray;
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateInicio.FormatCustom = null;
            this.dateInicio.Location = new System.Drawing.Point(140, 31);
            this.dateInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(394, 44);
            this.dateInicio.TabIndex = 53;
            this.dateInicio.Value = new System.DateTime(2020, 9, 15, 10, 48, 13, 902);
            this.dateInicio.onValueChanged += new System.EventHandler(this.dateInicio_onValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Buscar desde:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblEmpresa.Location = new System.Drawing.Point(31, 111);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(184, 18);
            this.lblEmpresa.TabIndex = 49;
            this.lblEmpresa.Text = "Ciudad de nacionalización:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2,
            this.lineShape5,
            this.lineShape8,
            this.lineShape42});
            this.shapeContainer2.Size = new System.Drawing.Size(1006, 215);
            this.shapeContainer2.TabIndex = 50;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 26;
            this.lineShape1.Y1 = 198;
            this.lineShape1.Y2 = 175;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 583;
            this.lineShape2.X2 = 962;
            this.lineShape2.Y1 = 74;
            this.lineShape2.Y2 = 74;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 149;
            this.lineShape5.X2 = 528;
            this.lineShape5.Y1 = 74;
            this.lineShape5.Y2 = 74;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape8.Enabled = false;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 27;
            this.lineShape8.X2 = 27;
            this.lineShape8.Y1 = 131;
            this.lineShape8.Y2 = 108;
            // 
            // lineShape42
            // 
            this.lineShape42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape42.Enabled = false;
            this.lineShape42.Name = "lineShape42";
            this.lineShape42.X1 = 27;
            this.lineShape42.X2 = 27;
            this.lineShape42.Y1 = 65;
            this.lineShape42.Y2 = 42;
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.dataGridTramites);
            this.panelDatos.Location = new System.Drawing.Point(3, 423);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1008, 293);
            this.panelDatos.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 33);
            this.label4.TabIndex = 59;
            this.label4.Text = "Documentos sin comisionar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridTramites
            // 
            this.dataGridTramites.AllowUserToAddRows = false;
            this.dataGridTramites.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTramites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTramites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTramites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTramites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridTramites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "--------------";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTramites.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTramites.DoubleBuffered = true;
            this.dataGridTramites.EnableHeadersVisualStyles = false;
            this.dataGridTramites.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTramites.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridTramites.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridTramites.Location = new System.Drawing.Point(26, 71);
            this.dataGridTramites.Name = "dataGridTramites";
            this.dataGridTramites.ReadOnly = true;
            this.dataGridTramites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTramites.Size = new System.Drawing.Size(951, 190);
            this.dataGridTramites.StandardTab = true;
            this.dataGridTramites.TabIndex = 3;
            this.dataGridTramites.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTramites_CellMouseDoubleClick);
            // 
            // redondeoBtnCrear
            // 
            this.redondeoBtnCrear.ElipseRadius = 20;
            this.redondeoBtnCrear.TargetControl = this;
            // 
            // FormPreCrearComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1050, 780);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreCrearComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPreCrearComision";
            this.Load += new System.EventHandler(this.FormPreCrearComision_Load);
            this.Shown += new System.EventHandler(this.FormPreCrearComision_Shown);
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelTituloFiltro.ResumeLayout(false);
            this.panelTituloFiltro.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelGeneral;
        private System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTituloFiltro;
        public System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape42;
        private Bunifu.Framework.UI.BunifuDatepicker dateFin;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateInicio;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbCiudadNacionalizacion;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelDatos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTramites;
        public System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnCrear;
    }
}