
namespace Presentacion
{
    partial class FormEditarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSecuencialCliente = new System.Windows.Forms.TextBox();
            this.txtDAI = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSecuencialCliente = new System.Windows.Forms.Label();
            this.lblDAI = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape53 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape52 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape51 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape50 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape49 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape39 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.liniaDAIS = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape42 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridPagos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.vScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.minimizar);
            this.panelOpciones.Controls.Add(this.maximizar);
            this.panelOpciones.Controls.Add(this.cerrar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1022, 36);
            this.panelOpciones.TabIndex = 2;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(930, 10);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(17, 16);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 43;
            this.minimizar.TabStop = false;
            this.minimizar.Visible = false;
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(959, 10);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(15, 15);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 5;
            this.maximizar.TabStop = false;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.cerrar.Location = new System.Drawing.Point(982, 9);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(17, 16);
            this.cerrar.TabIndex = 4;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 36);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(999, 556);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(959, 100);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.lblTitulo.Location = new System.Drawing.Point(415, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 52);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "PAGOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtCliente);
            this.panel5.Controls.Add(this.txtSecuencialCliente);
            this.panel5.Controls.Add(this.txtDAI);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.lblCliente);
            this.panel5.Controls.Add(this.lblSecuencialCliente);
            this.panel5.Controls.Add(this.lblDAI);
            this.panel5.Controls.Add(this.txtTramite);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.shapeContainer2);
            this.panel5.Location = new System.Drawing.Point(3, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(960, 199);
            this.panel5.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCliente.Location = new System.Drawing.Point(106, 148);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(328, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // txtSecuencialCliente
            // 
            this.txtSecuencialCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtSecuencialCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecuencialCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencialCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtSecuencialCliente.Location = new System.Drawing.Point(691, 146);
            this.txtSecuencialCliente.Name = "txtSecuencialCliente";
            this.txtSecuencialCliente.Size = new System.Drawing.Size(211, 20);
            this.txtSecuencialCliente.TabIndex = 4;
            this.txtSecuencialCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDAI
            // 
            this.txtDAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDAI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAI.ForeColor = System.Drawing.Color.DimGray;
            this.txtDAI.Location = new System.Drawing.Point(591, 98);
            this.txtDAI.Name = "txtDAI";
            this.txtDAI.Size = new System.Drawing.Size(274, 20);
            this.txtDAI.TabIndex = 3;
            this.txtDAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.label36.Location = new System.Drawing.Point(21, 17);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(317, 33);
            this.label36.TabIndex = 58;
            this.label36.Text = "INFORMACIÓN TRÁMITE";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblCliente.Location = new System.Drawing.Point(32, 149);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 60;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblSecuencialCliente
            // 
            this.lblSecuencialCliente.AutoSize = true;
            this.lblSecuencialCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecuencialCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblSecuencialCliente.Location = new System.Drawing.Point(557, 150);
            this.lblSecuencialCliente.Name = "lblSecuencialCliente";
            this.lblSecuencialCliente.Size = new System.Drawing.Size(137, 18);
            this.lblSecuencialCliente.TabIndex = 59;
            this.lblSecuencialCliente.Text = "Secuencial Cliente: ";
            // 
            // lblDAI
            // 
            this.lblDAI.AutoSize = true;
            this.lblDAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblDAI.Location = new System.Drawing.Point(557, 99);
            this.lblDAI.Name = "lblDAI";
            this.lblDAI.Size = new System.Drawing.Size(39, 18);
            this.lblDAI.TabIndex = 58;
            this.lblDAI.Text = "DAI: ";
            // 
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTramite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.ForeColor = System.Drawing.Color.DimGray;
            this.txtTramite.Location = new System.Drawing.Point(117, 97);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(236, 24);
            this.txtTramite.TabIndex = 1;
            this.txtTramite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Trámite:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape53,
            this.lineShape52,
            this.lineShape51,
            this.lineShape50,
            this.lineShape49,
            this.lineShape39,
            this.liniaDAIS,
            this.lineShape5,
            this.lineShape42});
            this.shapeContainer2.Size = new System.Drawing.Size(958, 197);
            this.shapeContainer2.TabIndex = 50;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape53
            // 
            this.lineShape53.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape53.Enabled = false;
            this.lineShape53.Name = "lineShape53";
            this.lineShape53.X1 = 26;
            this.lineShape53.X2 = 365;
            this.lineShape53.Y1 = 56;
            this.lineShape53.Y2 = 56;
            // 
            // lineShape52
            // 
            this.lineShape52.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape52.Enabled = false;
            this.lineShape52.Name = "lineShape52";
            this.lineShape52.X1 = 693;
            this.lineShape52.X2 = 909;
            this.lineShape52.Y1 = 168;
            this.lineShape52.Y2 = 168;
            // 
            // lineShape51
            // 
            this.lineShape51.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape51.Enabled = false;
            this.lineShape51.Name = "lineShape51";
            this.lineShape51.X1 = 99;
            this.lineShape51.X2 = 435;
            this.lineShape51.Y1 = 168;
            this.lineShape51.Y2 = 168;
            // 
            // lineShape50
            // 
            this.lineShape50.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape50.Enabled = false;
            this.lineShape50.Name = "lineShape50";
            this.lineShape50.X1 = 27;
            this.lineShape50.X2 = 27;
            this.lineShape50.Y1 = 168;
            this.lineShape50.Y2 = 145;
            // 
            // lineShape49
            // 
            this.lineShape49.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape49.Enabled = false;
            this.lineShape49.Name = "lineShape49";
            this.lineShape49.X1 = 553;
            this.lineShape49.X2 = 553;
            this.lineShape49.Y1 = 171;
            this.lineShape49.Y2 = 148;
            // 
            // lineShape39
            // 
            this.lineShape39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape39.Enabled = false;
            this.lineShape39.Name = "lineShape39";
            this.lineShape39.X1 = 553;
            this.lineShape39.X2 = 553;
            this.lineShape39.Y1 = 120;
            this.lineShape39.Y2 = 97;
            // 
            // liniaDAIS
            // 
            this.liniaDAIS.BorderColor = System.Drawing.Color.DimGray;
            this.liniaDAIS.Enabled = false;
            this.liniaDAIS.Name = "liniaDAIS";
            this.liniaDAIS.X1 = 593;
            this.liniaDAIS.X2 = 866;
            this.liniaDAIS.Y1 = 118;
            this.liniaDAIS.Y2 = 118;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 106;
            this.lineShape5.X2 = 352;
            this.lineShape5.Y1 = 121;
            this.lineShape5.Y2 = 121;
            // 
            // lineShape42
            // 
            this.lineShape42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lineShape42.Enabled = false;
            this.lineShape42.Name = "lineShape42";
            this.lineShape42.X1 = 27;
            this.lineShape42.X2 = 27;
            this.lineShape42.Y1 = 118;
            this.lineShape42.Y2 = 95;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hScrollBar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.dataGridPagos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 358);
            this.panel1.TabIndex = 4;
            // 
            // hScrollBar
            // 
            this.hScrollBar.AllowCursorChanges = true;
            this.hScrollBar.AllowHomeEndKeysDetection = false;
            this.hScrollBar.AllowIncrementalClickMoves = true;
            this.hScrollBar.AllowMouseDownEffects = true;
            this.hScrollBar.AllowMouseHoverEffects = true;
            this.hScrollBar.AllowScrollingAnimations = true;
            this.hScrollBar.AllowScrollKeysDetection = true;
            this.hScrollBar.AllowScrollOptionsMenu = true;
            this.hScrollBar.AllowShrinkingOnFocusLost = false;
            this.hScrollBar.BackgoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.hScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hScrollBar.BackgroundImage")));
            this.hScrollBar.BindingContainer = null;
            this.hScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.hScrollBar.BorderRadius = 0;
            this.hScrollBar.BorderThickness = 1;
            this.hScrollBar.DurationBeforeShrink = 2000;
            this.hScrollBar.LargeChange = 10;
            this.hScrollBar.Location = new System.Drawing.Point(26, 331);
            this.hScrollBar.Maximum = 100;
            this.hScrollBar.Minimum = 0;
            this.hScrollBar.MinimumThumbLength = 18;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.hScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.hScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.hScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.hScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.hScrollBar.ShrinkSizeLimit = 3;
            this.hScrollBar.Size = new System.Drawing.Size(917, 17);
            this.hScrollBar.SmallChange = 1;
            this.hScrollBar.TabIndex = 70;
            this.hScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.hScrollBar.ThumbLength = 90;
            this.hScrollBar.ThumbMargin = 1;
            this.hScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.hScrollBar.Value = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnEliminar.Location = new System.Drawing.Point(833, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 38);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridPagos
            // 
            this.dataGridPagos.AllowUserToAddRows = false;
            this.dataGridPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "--------------";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPagos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPagos.DoubleBuffered = true;
            this.dataGridPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridPagos.EnableHeadersVisualStyles = false;
            this.dataGridPagos.GridColor = System.Drawing.Color.DimGray;
            this.dataGridPagos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridPagos.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridPagos.Location = new System.Drawing.Point(26, 74);
            this.dataGridPagos.MultiSelect = false;
            this.dataGridPagos.Name = "dataGridPagos";
            this.dataGridPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPagos.Size = new System.Drawing.Size(917, 274);
            this.dataGridPagos.StandardTab = true;
            this.dataGridPagos.TabIndex = 59;
            this.dataGridPagos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPagos_CellDoubleClick);
            this.dataGridPagos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPagos_CellEndEdit);
            this.dataGridPagos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPagos_CellEnter);
            this.dataGridPagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridPagos_KeyPress);
            this.dataGridPagos.Resize += new System.EventHandler(this.dataGridPagos_Resize);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 58;
            this.label1.Text = "LISTA PAGOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(958, 356);
            this.shapeContainer1.TabIndex = 50;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape53";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 215;
            this.lineShape1.Y1 = 56;
            this.lineShape1.Y2 = 56;
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
            this.vScrollBar.Location = new System.Drawing.Point(1005, 36);
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
            this.vScrollBar.Size = new System.Drawing.Size(17, 556);
            this.vScrollBar.SmallChange = 1;
            this.vScrollBar.TabIndex = 48;
            this.vScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.vScrollBar.ThumbLength = 108;
            this.vScrollBar.ThumbMargin = 1;
            this.vScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vScrollBar.Value = 0;
            this.vScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.vScrollBar_Scroll);
            // 
            // FormEditarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1022, 592);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormEditarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarPago";
            this.Load += new System.EventHandler(this.FormEditarPago_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEditarPago_KeyDown);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        public System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
        private System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnEliminar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridPagos;
        public System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtSecuencialCliente;
        public System.Windows.Forms.TextBox txtDAI;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblSecuencialCliente;
        public System.Windows.Forms.Label lblDAI;
        public System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape53;
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape52;
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape51;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape50;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape49;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape39;
        public Microsoft.VisualBasic.PowerPacks.LineShape liniaDAIS;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape42;
        private Bunifu.UI.WinForms.BunifuVScrollBar vScrollBar;
        private Bunifu.UI.WinForms.BunifuHScrollBar hScrollBar;
    }
}