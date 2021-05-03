
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesSaldoCliente));
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
            this.panelDesde = new System.Windows.Forms.Panel();
            this.dateTransferencia = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalleTransferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panelTramites = new System.Windows.Forms.Panel();
            this.fechaFiltro = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTransferible = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridDestino = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.VScroll = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.dataGridTramites = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetalleTrans = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelDevolucion = new System.Windows.Forms.Panel();
            this.txtValorSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.vScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.redondeoLblT = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesde.SuspendLayout();
            this.panelTramites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).BeginInit();
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
            "Transferir saldo a otro(s) trámite(s)",
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
            this.panelPropiedades.Size = new System.Drawing.Size(1072, 37);
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
            this.cerrar.Location = new System.Drawing.Point(1033, 7);
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
            this.maximizar.Location = new System.Drawing.Point(1012, 8);
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
            this.panelContenedor.Controls.Add(this.panelDesde);
            this.panelContenedor.Controls.Add(this.panelTramites);
            this.panelContenedor.Controls.Add(this.panelDevolucion);
            this.panelContenedor.Controls.Add(this.panelInferior);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1049, 743);
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
            // panelDesde
            // 
            this.panelDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesde.Controls.Add(this.dateTransferencia);
            this.panelDesde.Controls.Add(this.label4);
            this.panelDesde.Controls.Add(this.txtDetalleTransferencia);
            this.panelDesde.Controls.Add(this.label5);
            this.panelDesde.Controls.Add(this.lblDetalle);
            this.panelDesde.Location = new System.Drawing.Point(3, 312);
            this.panelDesde.Name = "panelDesde";
            this.panelDesde.Size = new System.Drawing.Size(1008, 227);
            this.panelDesde.TabIndex = 42;
            this.panelDesde.Visible = false;
            // 
            // dateTransferencia
            // 
            this.dateTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dateTransferencia.BorderRadius = 0;
            this.dateTransferencia.ForeColor = System.Drawing.Color.White;
            this.dateTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTransferencia.FormatCustom = null;
            this.dateTransferencia.Location = new System.Drawing.Point(145, 157);
            this.dateTransferencia.Name = "dateTransferencia";
            this.dateTransferencia.Size = new System.Drawing.Size(303, 36);
            this.dateTransferencia.TabIndex = 82;
            this.dateTransferencia.Value = new System.DateTime(2021, 4, 14, 21, 49, 55, 482);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(73, 166);
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
            this.txtDetalleTransferencia.Location = new System.Drawing.Point(191, 83);
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
            this.label5.Location = new System.Drawing.Point(73, 93);
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
            // panelTramites
            // 
            this.panelTramites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTramites.Controls.Add(this.fechaFiltro);
            this.panelTramites.Controls.Add(this.lblFiltro);
            this.panelTramites.Controls.Add(this.txtBuscar);
            this.panelTramites.Controls.Add(this.lblTransferible);
            this.panelTramites.Controls.Add(this.label7);
            this.panelTramites.Controls.Add(this.lblTotal);
            this.panelTramites.Controls.Add(this.label3);
            this.panelTramites.Controls.Add(this.label2);
            this.panelTramites.Controls.Add(this.DataGridDestino);
            this.panelTramites.Controls.Add(this.VScroll);
            this.panelTramites.Controls.Add(this.dataGridTramites);
            this.panelTramites.Controls.Add(this.label1);
            this.panelTramites.Controls.Add(this.lblDetalleTrans);
            this.panelTramites.Controls.Add(this.shapeContainer3);
            this.panelTramites.Location = new System.Drawing.Point(3, 545);
            this.panelTramites.Name = "panelTramites";
            this.panelTramites.Size = new System.Drawing.Size(1008, 337);
            this.panelTramites.TabIndex = 43;
            this.panelTramites.Visible = false;
            // 
            // fechaFiltro
            // 
            this.fechaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.fechaFiltro.BorderRadius = 0;
            this.fechaFiltro.Enabled = false;
            this.fechaFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.fechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaFiltro.FormatCustom = "";
            this.fechaFiltro.Location = new System.Drawing.Point(317, 74);
            this.fechaFiltro.Name = "fechaFiltro";
            this.fechaFiltro.Size = new System.Drawing.Size(300, 28);
            this.fechaFiltro.TabIndex = 102;
            this.fechaFiltro.Value = new System.DateTime(2021, 4, 12, 14, 9, 30, 164);
            this.fechaFiltro.Visible = false;
            this.fechaFiltro.onValueChanged += new System.EventHandler(this.fechaFiltro_onValueChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lblFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.lblFiltro.Location = new System.Drawing.Point(317, 105);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(223, 22);
            this.lblFiltro.TabIndex = 101;
            this.lblFiltro.Text = "   FILTRAR POR:  ";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFiltro.Click += new System.EventHandler(this.lblFiltro_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(117, 102);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(194, 24);
            this.txtBuscar.TabIndex = 87;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblTransferible
            // 
            this.lblTransferible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.lblTransferible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTransferible.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferible.ForeColor = System.Drawing.Color.LightGray;
            this.lblTransferible.Location = new System.Drawing.Point(882, 299);
            this.lblTransferible.Name = "lblTransferible";
            this.lblTransferible.Size = new System.Drawing.Size(107, 25);
            this.lblTransferible.TabIndex = 100;
            this.lblTransferible.Text = "$   0,00";
            this.lblTransferible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(631, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "  TRANSFERIBLE:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotal.Location = new System.Drawing.Point(882, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 25);
            this.lblTotal.TabIndex = 98;
            this.lblTotal.Text = "$   0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(631, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "   TOTAL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(629, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 96;
            this.label2.Text = "TRANSFERENCIAS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridDestino
            // 
            this.DataGridDestino.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.DataGridDestino.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridDestino.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.DataGridDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDestino.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDestino.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDestino.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDestino.DoubleBuffered = true;
            this.DataGridDestino.EnableHeadersVisualStyles = false;
            this.DataGridDestino.GridColor = System.Drawing.Color.DimGray;
            this.DataGridDestino.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.DataGridDestino.HeaderForeColor = System.Drawing.Color.LightGray;
            this.DataGridDestino.Location = new System.Drawing.Point(631, 146);
            this.DataGridDestino.Name = "DataGridDestino";
            this.DataGridDestino.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDestino.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridDestino.RowHeadersWidth = 4;
            this.DataGridDestino.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridDestino.Size = new System.Drawing.Size(358, 125);
            this.DataGridDestino.StandardTab = true;
            this.DataGridDestino.TabIndex = 86;
            this.DataGridDestino.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDestino_CellEndEdit);
            // 
            // VScroll
            // 
            this.VScroll.AllowCursorChanges = true;
            this.VScroll.AllowHomeEndKeysDetection = false;
            this.VScroll.AllowIncrementalClickMoves = true;
            this.VScroll.AllowMouseDownEffects = true;
            this.VScroll.AllowMouseHoverEffects = true;
            this.VScroll.AllowScrollingAnimations = true;
            this.VScroll.AllowScrollKeysDetection = true;
            this.VScroll.AllowScrollOptionsMenu = true;
            this.VScroll.AllowShrinkingOnFocusLost = false;
            this.VScroll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VScroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VScroll.BackgroundImage")));
            this.VScroll.BindingContainer = null;
            this.VScroll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VScroll.BorderRadius = 0;
            this.VScroll.BorderThickness = 1;
            this.VScroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VScroll.DurationBeforeShrink = 2000;
            this.VScroll.LargeChange = 20;
            this.VScroll.Location = new System.Drawing.Point(599, 146);
            this.VScroll.Maximum = 100;
            this.VScroll.Minimum = 0;
            this.VScroll.MinimumThumbLength = 18;
            this.VScroll.Name = "VScroll";
            this.VScroll.OnDisable.ScrollBarBorderColor = System.Drawing.Color.DimGray;
            this.VScroll.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.VScroll.OnDisable.ThumbColor = System.Drawing.Color.DimGray;
            this.VScroll.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VScroll.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VScroll.ShrinkSizeLimit = 3;
            this.VScroll.Size = new System.Drawing.Size(17, 172);
            this.VScroll.SmallChange = 1;
            this.VScroll.TabIndex = 94;
            this.VScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.VScroll.ThumbLength = 33;
            this.VScroll.ThumbMargin = 1;
            this.VScroll.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.VScroll.Value = 0;
            this.VScroll.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.VScroll_Scroll);
            // 
            // dataGridTramites
            // 
            this.dataGridTramites.AllowUserToAddRows = false;
            this.dataGridTramites.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTramites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTramites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTramites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridTramites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = "--------------";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTramites.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridTramites.DoubleBuffered = true;
            this.dataGridTramites.EnableHeadersVisualStyles = false;
            this.dataGridTramites.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTramites.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridTramites.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridTramites.Location = new System.Drawing.Point(30, 146);
            this.dataGridTramites.Name = "dataGridTramites";
            this.dataGridTramites.ReadOnly = true;
            this.dataGridTramites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridTramites.RowHeadersWidth = 4;
            this.dataGridTramites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTramites.Size = new System.Drawing.Size(586, 172);
            this.dataGridTramites.StandardTab = true;
            this.dataGridTramites.TabIndex = 93;
            this.dataGridTramites.Visible = false;
            this.dataGridTramites.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTramites_CellDoubleClick);
            this.dataGridTramites.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridTramites_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "BUSCAR:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleTrans
            // 
            this.lblDetalleTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lblDetalleTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetalleTrans.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTrans.ForeColor = System.Drawing.Color.LightGray;
            this.lblDetalleTrans.Location = new System.Drawing.Point(17, 23);
            this.lblDetalleTrans.Name = "lblDetalleTrans";
            this.lblDetalleTrans.Size = new System.Drawing.Size(309, 40);
            this.lblDetalleTrans.TabIndex = 88;
            this.lblDetalleTrans.Text = "  DETALLE TRANSFERENCIA:";
            this.lblDetalleTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(1006, 335);
            this.shapeContainer3.TabIndex = 92;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.Color.White;
            this.lineShape3.X1 = 631;
            this.lineShape3.X2 = 921;
            this.lineShape3.Y1 = 133;
            this.lineShape3.Y2 = 133;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.White;
            this.lineShape2.X1 = 30;
            this.lineShape2.X2 = 485;
            this.lineShape2.Y1 = 133;
            this.lineShape2.Y2 = 133;
            // 
            // panelDevolucion
            // 
            this.panelDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDevolucion.Controls.Add(this.txtValorSaldo);
            this.panelDevolucion.Controls.Add(this.label6);
            this.panelDevolucion.Location = new System.Drawing.Point(3, 888);
            this.panelDevolucion.Name = "panelDevolucion";
            this.panelDevolucion.Size = new System.Drawing.Size(1008, 90);
            this.panelDevolucion.TabIndex = 44;
            this.panelDevolucion.Visible = false;
            // 
            // txtValorSaldo
            // 
            this.txtValorSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.txtValorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorSaldo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSaldo.ForeColor = System.Drawing.Color.White;
            this.txtValorSaldo.Location = new System.Drawing.Point(320, 16);
            this.txtValorSaldo.Name = "txtValorSaldo";
            this.txtValorSaldo.Size = new System.Drawing.Size(283, 40);
            this.txtValorSaldo.TabIndex = 101;
            this.txtValorSaldo.Text = "0,00";
            this.txtValorSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorSaldo.TextChanged += new System.EventHandler(this.txtValorSaldo_TextChanged);
            this.txtValorSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorSaldo_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 40);
            this.label6.TabIndex = 89;
            this.label6.Text = "  DEVOLUCIÓN DINERO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnGuardar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(3, 984);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1008, 61);
            this.panelInferior.TabIndex = 38;
            this.panelInferior.Visible = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.AllowCursorChanges = true;
            this.vScrollBar.AllowHomeEndKeysDetection = false;
            this.vScrollBar.AllowIncrementalClickMoves = true;
            this.vScrollBar.AllowMouseDownEffects = true;
            this.vScrollBar.AllowMouseHoverEffects = true;
            this.vScrollBar.AllowScrollingAnimations = true;
            this.vScrollBar.AllowScrollKeysDetection = true;
            this.vScrollBar.AllowScrollOptionsMenu = true;
            this.vScrollBar.AllowShrinkingOnFocusLost = false;
            this.vScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vScrollBar.BackgroundImage")));
            this.vScrollBar.BindingContainer = null;
            this.vScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.BorderRadius = 0;
            this.vScrollBar.BorderThickness = 1;
            this.vScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.DurationBeforeShrink = 2000;
            this.vScrollBar.LargeChange = 10;
            this.vScrollBar.Location = new System.Drawing.Point(1055, 37);
            this.vScrollBar.Maximum = 50;
            this.vScrollBar.Minimum = 0;
            this.vScrollBar.MinimumThumbLength = 18;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.DimGray;
            this.vScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vScrollBar.OnDisable.ThumbColor = System.Drawing.Color.DimGray;
            this.vScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.ShrinkSizeLimit = 3;
            this.vScrollBar.Size = new System.Drawing.Size(17, 743);
            this.vScrollBar.SmallChange = 1;
            this.vScrollBar.TabIndex = 88;
            this.vScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.vScrollBar.ThumbLength = 145;
            this.vScrollBar.ThumbMargin = 1;
            this.vScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vScrollBar.Value = 0;
            this.vScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.vScrollBar_Scroll);
            // 
            // redondeoLblT
            // 
            this.redondeoLblT.ElipseRadius = 20;
            this.redondeoLblT.TargetControl = this.lblDetalleTrans;
            // 
            // FormOpcionesSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1072, 780);
            this.Controls.Add(this.vScrollBar);
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
            this.panelDesde.ResumeLayout(false);
            this.panelDesde.PerformLayout();
            this.panelTramites.ResumeLayout(false);
            this.panelTramites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).EndInit();
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
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelDesde;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDetalleTransferencia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblDetalle;
        private Bunifu.UI.WinForms.BunifuVScrollBar vScrollBar;
        private System.Windows.Forms.Panel panelTramites;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDestino;
        public System.Windows.Forms.Label lblDetalleTrans;
        private Bunifu.Framework.UI.BunifuElipse redondeoLblT;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTramites;
        private Bunifu.UI.WinForms.BunifuVScrollBar VScroll;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTransferible;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblFiltro;
        private Bunifu.Framework.UI.BunifuDatepicker fechaFiltro;
        private Bunifu.Framework.UI.BunifuDatepicker dateTransferencia;
        private System.Windows.Forms.Panel panelDevolucion;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtValorSaldo;
    }
}