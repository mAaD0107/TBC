namespace Presentacion
{
    partial class FormBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarClientes));
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Label();
            this.panelTabla = new System.Windows.Forms.TableLayoutPanel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.hScrollBar = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.vScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelBtnDer = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelBtnIzq = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.RedondeoBtnDesplegar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBrnActualizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnEditar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnEliminar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelTabla.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelBtnDer.SuspendLayout();
            this.panelBtnIzq.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDesplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesplegar.FlatAppearance.BorderSize = 0;
            this.btnDesplegar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDesplegar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegar.ForeColor = System.Drawing.Color.LightGray;
            this.btnDesplegar.Location = new System.Drawing.Point(18, 3);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(268, 40);
            this.btnDesplegar.TabIndex = 4;
            this.btnDesplegar.Text = "Desplegar";
            this.btnDesplegar.UseVisualStyleBackColor = false;
            this.btnDesplegar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(144, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.lblBuscar.Location = new System.Drawing.Point(18, 6);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(114, 30);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "BUSCAR:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "--------------";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClientes.DoubleBuffered = true;
            this.dataGridClientes.EnableHeadersVisualStyles = false;
            this.dataGridClientes.GridColor = System.Drawing.Color.DimGray;
            this.dataGridClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridClientes.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(806, 332);
            this.dataGridClientes.StandardTab = true;
            this.dataGridClientes.TabIndex = 2;
            this.dataGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellDoubleClick);
            this.dataGridClientes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridClientes_Scroll);
            this.dataGridClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridClientes_MouseClick);
            // 
            // panelGeneral
            // 
            this.panelGeneral.ColumnCount = 1;
            this.panelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelGeneral.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.panelGeneral.Controls.Add(this.panelTabla, 0, 1);
            this.panelGeneral.Controls.Add(this.panelBotones, 0, 2);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.RowCount = 3;
            this.panelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.9697F));
            this.panelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.0303F));
            this.panelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.panelGeneral.Size = new System.Drawing.Size(836, 550);
            this.panelGeneral.TabIndex = 44;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuGradientPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuGradientPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 93);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscar);
            this.bunifuGradientPanel1.Controls.Add(this.lblBuscar);
            this.bunifuGradientPanel1.Controls.Add(this.shapeContainer1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 33);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(824, 57);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(824, 57);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.White;
            this.lineShape1.X1 = 17;
            this.lineShape1.X2 = 472;
            this.lineShape1.Y1 = 39;
            this.lineShape1.Y2 = 39;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.maximizar);
            this.bunifuGradientPanel4.Controls.Add(this.cerrar);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(824, 24);
            this.bunifuGradientPanel4.TabIndex = 1;
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(781, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(15, 15);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 4;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.cerrar.Location = new System.Drawing.Point(804, 1);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(17, 16);
            this.cerrar.TabIndex = 3;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.ColumnCount = 3;
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9744214F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.02558F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelTabla.Controls.Add(this.panelDatos, 1, 0);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(3, 102);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.RowCount = 2;
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.panelTabla.Size = new System.Drawing.Size(830, 346);
            this.panelTabla.TabIndex = 41;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.hScrollBar);
            this.panelDatos.Controls.Add(this.vScrollBar);
            this.panelDatos.Controls.Add(this.dataGridClientes);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(10, 3);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(806, 332);
            this.panelDatos.TabIndex = 0;
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
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.DurationBeforeShrink = 2000;
            this.hScrollBar.LargeChange = 10;
            this.hScrollBar.Location = new System.Drawing.Point(0, 315);
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
            this.hScrollBar.Size = new System.Drawing.Size(789, 17);
            this.hScrollBar.SmallChange = 1;
            this.hScrollBar.TabIndex = 47;
            this.hScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.hScrollBar.ThumbLength = 77;
            this.hScrollBar.ThumbMargin = 1;
            this.hScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.hScrollBar.Value = 0;
            this.hScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs>(this.hScrollBar_Scroll);
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
            this.vScrollBar.LargeChange = 20;
            this.vScrollBar.Location = new System.Drawing.Point(789, 0);
            this.vScrollBar.Maximum = 100;
            this.vScrollBar.Minimum = 0;
            this.vScrollBar.MinimumThumbLength = 18;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.DimGray;
            this.vScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vScrollBar.OnDisable.ThumbColor = System.Drawing.Color.DimGray;
            this.vScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.vScrollBar.ShrinkSizeLimit = 3;
            this.vScrollBar.Size = new System.Drawing.Size(17, 332);
            this.vScrollBar.SmallChange = 1;
            this.vScrollBar.TabIndex = 46;
            this.vScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.vScrollBar.ThumbLength = 65;
            this.vScrollBar.ThumbMargin = 1;
            this.vScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vScrollBar.Value = 0;
            this.vScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.vScrollBar_Scroll);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.panelBtnDer);
            this.panelBotones.Controls.Add(this.panelBtnIzq);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(3, 454);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(830, 93);
            this.panelBotones.TabIndex = 42;
            // 
            // panelBtnDer
            // 
            this.panelBtnDer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnDer.Controls.Add(this.btnDesplegar);
            this.panelBtnDer.Controls.Add(this.btnEliminar);
            this.panelBtnDer.Location = new System.Drawing.Point(466, 3);
            this.panelBtnDer.Name = "panelBtnDer";
            this.panelBtnDer.Size = new System.Drawing.Size(364, 90);
            this.panelBtnDer.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Location = new System.Drawing.Point(18, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panelBtnIzq
            // 
            this.panelBtnIzq.Controls.Add(this.btnActualizar);
            this.panelBtnIzq.Controls.Add(this.btnEditar);
            this.panelBtnIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtnIzq.Location = new System.Drawing.Point(0, 0);
            this.panelBtnIzq.Name = "panelBtnIzq";
            this.panelBtnIzq.Size = new System.Drawing.Size(435, 93);
            this.panelBtnIzq.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizar.Location = new System.Drawing.Point(132, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(276, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.Location = new System.Drawing.Point(132, 48);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(276, 40);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // RedondeoBtnDesplegar
            // 
            this.RedondeoBtnDesplegar.ElipseRadius = 20;
            this.RedondeoBtnDesplegar.TargetControl = this.btnDesplegar;
            // 
            // redondeoBrnActualizar
            // 
            this.redondeoBrnActualizar.ElipseRadius = 20;
            this.redondeoBrnActualizar.TargetControl = this.btnActualizar;
            // 
            // redondeoBtnEditar
            // 
            this.redondeoBtnEditar.ElipseRadius = 20;
            this.redondeoBtnEditar.TargetControl = this.btnEditar;
            // 
            // redondeoBtnEliminar
            // 
            this.redondeoBtnEliminar.ElipseRadius = 20;
            this.redondeoBtnEliminar.TargetControl = this.btnEliminar;
            // 
            // FormBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(836, 550);
            this.Controls.Add(this.panelGeneral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormBuscarClientes";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarClientes";
            this.Load += new System.EventHandler(this.FormBuscarClientes_Load);
            this.Shown += new System.EventHandler(this.FormBuscarClientes_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarClientes_KeyDown);
            this.Resize += new System.EventHandler(this.FormBuscarClientes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelBtnDer.ResumeLayout(false);
            this.panelBtnIzq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDesplegar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.Label cerrar;
        private Bunifu.Framework.UI.BunifuElipse RedondeoBtnDesplegar;
        private System.Windows.Forms.TableLayoutPanel panelTabla;
        private System.Windows.Forms.Button btnActualizar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBrnActualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnEditar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnEliminar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelBtnDer;
        private System.Windows.Forms.Panel panelBtnIzq;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelDatos;
        private Bunifu.UI.WinForms.BunifuVScrollBar vScrollBar;
        private Bunifu.UI.WinForms.BunifuHScrollBar hScrollBar;
        public System.Windows.Forms.TableLayoutPanel panelGeneral;
    }
}