
namespace Presentacion
{
    partial class FormOpcionesSaldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesSaldoCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbOpcionesSaldo = new System.Windows.Forms.ComboBox();
            this.lblDestinoPagoPG = new System.Windows.Forms.Label();
            this.redondeoForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnAceptar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Label();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTramites = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridTramites = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelDesde = new System.Windows.Forms.Panel();
            this.dateTransferencia = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalleTransferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblDesdeHasta = new System.Windows.Forms.Label();
            this.panelDevolucion = new System.Windows.Forms.Panel();
            this.txtValorSaldo = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape25 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTramites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).BeginInit();
            this.panelDesde.SuspendLayout();
            this.panelDevolucion.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOpcionesSaldo
            // 
            this.cmbOpcionesSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cmbOpcionesSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOpcionesSaldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOpcionesSaldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpcionesSaldo.ForeColor = System.Drawing.Color.Transparent;
            this.cmbOpcionesSaldo.FormattingEnabled = true;
            this.cmbOpcionesSaldo.Items.AddRange(new object[] {
            "",
            "Transferir saldo a otro trámite",
            "Devolver Dinero "});
            this.cmbOpcionesSaldo.Location = new System.Drawing.Point(117, 55);
            this.cmbOpcionesSaldo.Margin = new System.Windows.Forms.Padding(1);
            this.cmbOpcionesSaldo.Name = "cmbOpcionesSaldo";
            this.cmbOpcionesSaldo.Size = new System.Drawing.Size(404, 25);
            this.cmbOpcionesSaldo.TabIndex = 83;
            this.cmbOpcionesSaldo.TextChanged += new System.EventHandler(this.cmbOpcionesSaldo_TextChanged);
            // 
            // lblDestinoPagoPG
            // 
            this.lblDestinoPagoPG.AutoSize = true;
            this.lblDestinoPagoPG.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinoPagoPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoPagoPG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblDestinoPagoPG.Location = new System.Drawing.Point(28, 58);
            this.lblDestinoPagoPG.Name = "lblDestinoPagoPG";
            this.lblDestinoPagoPG.Size = new System.Drawing.Size(76, 18);
            this.lblDestinoPagoPG.TabIndex = 82;
            this.lblDestinoPagoPG.Text = "Opciones:";
            // 
            // redondeoForm
            // 
            this.redondeoForm.ElipseRadius = 20;
            this.redondeoForm.TargetControl = this;
            // 
            // redondeoBtnAceptar
            // 
            this.redondeoBtnAceptar.ElipseRadius = 20;
            this.redondeoBtnAceptar.TargetControl = this.btnGuardar;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnGuardar.Location = new System.Drawing.Point(314, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(387, 44);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelPropiedades
            // 
            this.panelPropiedades.Controls.Add(this.cerrar);
            this.panelPropiedades.Controls.Add(this.maximizar);
            this.panelPropiedades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPropiedades.Location = new System.Drawing.Point(0, 0);
            this.panelPropiedades.Name = "panelPropiedades";
            this.panelPropiedades.Size = new System.Drawing.Size(1050, 37);
            this.panelPropiedades.TabIndex = 86;
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
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.panel18);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelTramites);
            this.panelContenedor.Controls.Add(this.panelDesde);
            this.panelContenedor.Controls.Add(this.panelDevolucion);
            this.panelContenedor.Controls.Add(this.panelInferior);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 743);
            this.panelContenedor.TabIndex = 87;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.lblTitulo);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1008, 75);
            this.panel18.TabIndex = 36;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.lblTitulo.Location = new System.Drawing.Point(318, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(378, 58);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "SALDO CLIENTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 75);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDestinoPagoPG);
            this.panel1.Controls.Add(this.cmbOpcionesSaldo);
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 141);
            this.panel1.TabIndex = 37;
            // 
            // panelTramites
            // 
            this.panelTramites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTramites.Controls.Add(this.txtBuscar);
            this.panelTramites.Controls.Add(this.lblBuscar);
            this.panelTramites.Controls.Add(this.dataGridTramites);
            this.panelTramites.Controls.Add(this.shapeContainer1);
            this.panelTramites.Location = new System.Drawing.Point(3, 312);
            this.panelTramites.Name = "panelTramites";
            this.panelTramites.Size = new System.Drawing.Size(1008, 510);
            this.panelTramites.TabIndex = 40;
            this.panelTramites.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(144, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 24);
            this.txtBuscar.TabIndex = 87;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lblBuscar.Location = new System.Drawing.Point(25, 23);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 32);
            this.lblBuscar.TabIndex = 88;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridTramites
            // 
            this.dataGridTramites.AllowUserToAddRows = false;
            this.dataGridTramites.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTramites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTramites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTramites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridTramites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.NullValue = "--------------";
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTramites.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridTramites.DoubleBuffered = true;
            this.dataGridTramites.EnableHeadersVisualStyles = false;
            this.dataGridTramites.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTramites.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridTramites.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridTramites.Location = new System.Drawing.Point(31, 71);
            this.dataGridTramites.Name = "dataGridTramites";
            this.dataGridTramites.ReadOnly = true;
            this.dataGridTramites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTramites.Size = new System.Drawing.Size(943, 412);
            this.dataGridTramites.StandardTab = true;
            this.dataGridTramites.TabIndex = 84;
            this.dataGridTramites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTramites_CellClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1006, 508);
            this.shapeContainer1.TabIndex = 89;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 145;
            this.lineShape1.X2 = 443;
            this.lineShape1.Y1 = 51;
            this.lineShape1.Y2 = 51;
            // 
            // panelDesde
            // 
            this.panelDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesde.Controls.Add(this.dateTransferencia);
            this.panelDesde.Controls.Add(this.label4);
            this.panelDesde.Controls.Add(this.txtDetalleTransferencia);
            this.panelDesde.Controls.Add(this.label5);
            this.panelDesde.Controls.Add(this.lblDetalle);
            this.panelDesde.Controls.Add(this.lblDesdeHasta);
            this.panelDesde.Location = new System.Drawing.Point(3, 828);
            this.panelDesde.Name = "panelDesde";
            this.panelDesde.Size = new System.Drawing.Size(1008, 255);
            this.panelDesde.TabIndex = 42;
            this.panelDesde.Visible = false;
            // 
            // dateTransferencia
            // 
            this.dateTransferencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dateTransferencia.BorderRadius = 0;
            this.dateTransferencia.ForeColor = System.Drawing.Color.White;
            this.dateTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTransferencia.FormatCustom = null;
            this.dateTransferencia.Location = new System.Drawing.Point(132, 203);
            this.dateTransferencia.Name = "dateTransferencia";
            this.dateTransferencia.Size = new System.Drawing.Size(441, 36);
            this.dateTransferencia.TabIndex = 81;
            this.dateTransferencia.Value = new System.DateTime(2021, 2, 8, 17, 47, 9, 159);
            this.dateTransferencia.onValueChanged += new System.EventHandler(this.dateTransferencia_onValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(73, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Fecha:";
            // 
            // txtDetalleTransferencia
            // 
            this.txtDetalleTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalleTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDetalleTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleTransferencia.ForeColor = System.Drawing.Color.LightGray;
            this.txtDetalleTransferencia.Location = new System.Drawing.Point(191, 134);
            this.txtDetalleTransferencia.Multiline = true;
            this.txtDetalleTransferencia.Name = "txtDetalleTransferencia";
            this.txtDetalleTransferencia.Size = new System.Drawing.Size(382, 50);
            this.txtDetalleTransferencia.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(73, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Observaciones:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.lblDetalle.Location = new System.Drawing.Point(15, 17);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(362, 36);
            this.lblDetalle.TabIndex = 80;
            this.lblDetalle.Text = "DETALLE TRANSFERENCIA";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesdeHasta
            // 
            this.lblDesdeHasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesdeHasta.AutoSize = true;
            this.lblDesdeHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesdeHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblDesdeHasta.Location = new System.Drawing.Point(71, 88);
            this.lblDesdeHasta.Name = "lblDesdeHasta";
            this.lblDesdeHasta.Size = new System.Drawing.Size(177, 27);
            this.lblDesdeHasta.TabIndex = 64;
            this.lblDesdeHasta.Text = "Desde -> Hasta";
            // 
            // panelDevolucion
            // 
            this.panelDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDevolucion.Controls.Add(this.txtValorSaldo);
            this.panelDevolucion.Controls.Add(this.lblVal);
            this.panelDevolucion.Controls.Add(this.shapeContainer2);
            this.panelDevolucion.Location = new System.Drawing.Point(3, 1089);
            this.panelDevolucion.Name = "panelDevolucion";
            this.panelDevolucion.Size = new System.Drawing.Size(1008, 138);
            this.panelDevolucion.TabIndex = 41;
            this.panelDevolucion.Visible = false;
            // 
            // txtValorSaldo
            // 
            this.txtValorSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtValorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorSaldo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSaldo.ForeColor = System.Drawing.Color.White;
            this.txtValorSaldo.Location = new System.Drawing.Point(270, 40);
            this.txtValorSaldo.Name = "txtValorSaldo";
            this.txtValorSaldo.Size = new System.Drawing.Size(240, 46);
            this.txtValorSaldo.TabIndex = 63;
            this.txtValorSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorSaldo.WordWrap = false;
            this.txtValorSaldo.TextChanged += new System.EventHandler(this.txtValorSaldo_TextChanged);
            this.txtValorSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalNotCredito_KeyPress);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblVal.Location = new System.Drawing.Point(47, 51);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(195, 25);
            this.lblVal.TabIndex = 64;
            this.lblVal.Text = "Valor a transferir: $";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape25});
            this.shapeContainer2.Size = new System.Drawing.Size(1006, 136);
            this.shapeContainer2.TabIndex = 65;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape25
            // 
            this.lineShape25.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape25.Enabled = false;
            this.lineShape25.Name = "lineShape25";
            this.lineShape25.X1 = 253;
            this.lineShape25.X2 = 518;
            this.lineShape25.Y1 = 86;
            this.lineShape25.Y2 = 86;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnGuardar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(3, 1233);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1008, 61);
            this.panelInferior.TabIndex = 38;
            this.panelInferior.Visible = false;
            // 
            // FormOpcionesSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1050, 780);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormOpcionesSaldoCliente";
            this.Text = "FormOpcionesSaldoCliente";
            this.Load += new System.EventHandler(this.FormOpcionesSaldoCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOpcionesSaldoCliente_KeyDown);
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTramites.ResumeLayout(false);
            this.panelTramites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).EndInit();
            this.panelDesde.ResumeLayout(false);
            this.panelDesde.PerformLayout();
            this.panelDevolucion.ResumeLayout(false);
            this.panelDevolucion.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbOpcionesSaldo;
        private System.Windows.Forms.Label lblDestinoPagoPG;
        private Bunifu.Framework.UI.BunifuElipse redondeoForm;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnAceptar;
        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTramites;
        private System.Windows.Forms.Panel panelTramites;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelDevolucion;
        public System.Windows.Forms.TextBox txtValorSaldo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape25;
        private System.Windows.Forms.Panel panelDesde;
        private System.Windows.Forms.Label lblDesdeHasta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDetalleTransferencia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblDetalle;
        private Bunifu.Framework.UI.BunifuDatepicker dateTransferencia;
        private System.Windows.Forms.Label lblVal;
    }
}