namespace Presentacion
{
    partial class FormBuscarTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarTramite));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBuscar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelOpciones = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Label();
            this.panelTabla = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTramites = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelBtnDer = new System.Windows.Forms.Panel();
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelBtnIzq = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.redondeoBtnActualizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnEditar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnDesplegar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoBtnEliminar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelBtnDer.SuspendLayout();
            this.panelBtnIzq.SuspendLayout();
            this.SuspendLayout();
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
            this.panelGeneral.TabIndex = 45;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelBuscar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelOpciones, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 93);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscar.BackgroundImage")));
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.lblBuscar);
            this.panelBuscar.Controls.Add(this.shapeContainer1);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelBuscar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelBuscar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelBuscar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelBuscar.Location = new System.Drawing.Point(3, 45);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Quality = 10;
            this.panelBuscar.Size = new System.Drawing.Size(824, 45);
            this.panelBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(137, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.lblBuscar.Location = new System.Drawing.Point(18, 6);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 32);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(824, 45);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 138;
            this.lineShape1.X2 = 436;
            this.lineShape1.Y1 = 37;
            this.lineShape1.Y2 = 37;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpciones.BackgroundImage")));
            this.panelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOpciones.Controls.Add(this.minimizar);
            this.panelOpciones.Controls.Add(this.maximizar);
            this.panelOpciones.Controls.Add(this.cerrar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelOpciones.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelOpciones.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelOpciones.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelOpciones.Location = new System.Drawing.Point(3, 3);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Quality = 10;
            this.panelOpciones.Size = new System.Drawing.Size(824, 36);
            this.panelOpciones.TabIndex = 1;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(780, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(17, 16);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 44;
            this.minimizar.TabStop = false;
            this.minimizar.Visible = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
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
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.012048F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.98795F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelTabla.Controls.Add(this.dataGridTramites, 1, 0);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(3, 102);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.RowCount = 2;
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.Size = new System.Drawing.Size(830, 346);
            this.panelTabla.TabIndex = 41;
            // 
            // dataGridTramites
            // 
            this.dataGridTramites.AllowUserToAddRows = false;
            this.dataGridTramites.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTramites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTramites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.dataGridTramites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTramites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridTramites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "--------------";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTramites.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTramites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTramites.DoubleBuffered = true;
            this.dataGridTramites.EnableHeadersVisualStyles = false;
            this.dataGridTramites.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTramites.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridTramites.HeaderForeColor = System.Drawing.Color.LightGray;
            this.dataGridTramites.Location = new System.Drawing.Point(26, 3);
            this.dataGridTramites.Name = "dataGridTramites";
            this.dataGridTramites.ReadOnly = true;
            this.dataGridTramites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTramites.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTramites.Size = new System.Drawing.Size(764, 320);
            this.dataGridTramites.StandardTab = true;
            this.dataGridTramites.TabIndex = 2;
            this.dataGridTramites.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTramites_CellDoubleClick);
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
            // btnDesplegar
            // 
            this.btnDesplegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDesplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesplegar.FlatAppearance.BorderSize = 0;
            this.btnDesplegar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDesplegar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnDesplegar.Location = new System.Drawing.Point(18, 3);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(268, 40);
            this.btnDesplegar.TabIndex = 4;
            this.btnDesplegar.Text = "Desplegar";
            this.btnDesplegar.UseVisualStyleBackColor = false;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
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
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
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
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.btnEditar.Location = new System.Drawing.Point(132, 48);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(276, 40);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // redondeoBtnActualizar
            // 
            this.redondeoBtnActualizar.ElipseRadius = 20;
            this.redondeoBtnActualizar.TargetControl = this.btnActualizar;
            // 
            // redondeoBtnEditar
            // 
            this.redondeoBtnEditar.ElipseRadius = 20;
            this.redondeoBtnEditar.TargetControl = this.btnEditar;
            // 
            // redondeoBtnDesplegar
            // 
            this.redondeoBtnDesplegar.ElipseRadius = 20;
            this.redondeoBtnDesplegar.TargetControl = this.btnDesplegar;
            // 
            // redondeoBtnEliminar
            // 
            this.redondeoBtnEliminar.ElipseRadius = 20;
            this.redondeoBtnEliminar.TargetControl = this.btnEliminar;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panelOpciones;
            this.DragControl.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.panelBuscar;
            this.DragControl2.Vertical = true;
            // 
            // FormBuscarTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(836, 550);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormBuscarTramite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarTramite";
            this.Load += new System.EventHandler(this.FormBuscarTramite_Load);
            this.Shown += new System.EventHandler(this.FormBuscarTramite_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBuscarTramite_KeyPress);
            this.Resize += new System.EventHandler(this.FormBuscarTramite_Resize);
            this.panelGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramites)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBtnDer.ResumeLayout(false);
            this.panelBtnIzq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelOpciones;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.TableLayoutPanel panelTabla;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnDesplegar;
        private System.Windows.Forms.Button btnEliminar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnActualizar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnEditar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnDesplegar;
        private Bunifu.Framework.UI.BunifuElipse redondeoBtnEliminar;
        public System.Windows.Forms.Panel panelBtnDer;
        public System.Windows.Forms.Panel panelBtnIzq;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnActualizar;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.PictureBox minimizar;
        public System.Windows.Forms.PictureBox maximizar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTramites;
    }
}