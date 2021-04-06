
namespace Presentacion
{
    partial class FormInformeCXCDetallado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListaCXCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnOcultarPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkListVencimiento = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCXCDBindingSource)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaCXCDBindingSource
            // 
            this.ListaCXCDBindingSource.DataSource = typeof(Domain.CuentasPorCobrarDetallado.ListaCXCD);
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.btnOcultarPanel);
            this.panelFiltros.Controls.Add(this.groupBox2);
            this.panelFiltros.Controls.Add(this.groupBox1);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(245, 603);
            this.panelFiltros.TabIndex = 2;
            // 
            // btnOcultarPanel
            // 
            this.btnOcultarPanel.Activecolor = System.Drawing.SystemColors.ControlDark;
            this.btnOcultarPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOcultarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOcultarPanel.BorderRadius = 0;
            this.btnOcultarPanel.ButtonText = "<";
            this.btnOcultarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarPanel.DisabledColor = System.Drawing.Color.Gray;
            this.btnOcultarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOcultarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOcultarPanel.Iconimage = null;
            this.btnOcultarPanel.Iconimage_right = null;
            this.btnOcultarPanel.Iconimage_right_Selected = null;
            this.btnOcultarPanel.Iconimage_Selected = null;
            this.btnOcultarPanel.IconMarginLeft = 0;
            this.btnOcultarPanel.IconMarginRight = 0;
            this.btnOcultarPanel.IconRightVisible = true;
            this.btnOcultarPanel.IconRightZoom = 0D;
            this.btnOcultarPanel.IconVisible = true;
            this.btnOcultarPanel.IconZoom = 90D;
            this.btnOcultarPanel.IsTab = false;
            this.btnOcultarPanel.Location = new System.Drawing.Point(230, 0);
            this.btnOcultarPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOcultarPanel.Name = "btnOcultarPanel";
            this.btnOcultarPanel.Normalcolor = System.Drawing.SystemColors.ControlLight;
            this.btnOcultarPanel.OnHovercolor = System.Drawing.SystemColors.ControlDark;
            this.btnOcultarPanel.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOcultarPanel.selected = false;
            this.btnOcultarPanel.Size = new System.Drawing.Size(15, 603);
            this.btnOcultarPanel.TabIndex = 7;
            this.btnOcultarPanel.Text = "<";
            this.btnOcultarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOcultarPanel.Textcolor = System.Drawing.Color.Black;
            this.btnOcultarPanel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarPanel.Click += new System.EventHandler(this.btnOcultarPanel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateHasta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateDesde);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha:";
            // 
            // dateHasta
            // 
            this.dateHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(12, 126);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(201, 20);
            this.dateHasta.TabIndex = 7;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde:";
            // 
            // dateDesde
            // 
            this.dateDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(12, 54);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(201, 20);
            this.dateDesde.TabIndex = 4;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkListVencimiento);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "TODOS",
            "NO VENCIDA",
            "1 - 30 Días",
            "31 - 60 Días",
            "61 - 90 Días",
            "+90 Días"});
            this.cmbEstado.Location = new System.Drawing.Point(12, 296);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(201, 21);
            this.cmbEstado.TabIndex = 7;
            this.cmbEstado.Visible = false;
            this.cmbEstado.TextChanged += new System.EventHandler(this.cmbClientes_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vencimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TODOS",
            "IMPORTACIONES",
            "EXPORTACIONES ",
            "OTROS SERVICIOS"});
            this.comboBox1.Location = new System.Drawing.Point(12, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Enabled = false;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(12, 45);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(201, 21);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.TextChanged += new System.EventHandler(this.cmbClientes_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "CXCDetallado";
            reportDataSource3.Value = this.ListaCXCDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.InformeCXCDetallado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(245, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(808, 603);
            this.reportViewer1.TabIndex = 3;
            // 
            // checkListVencimiento
            // 
            this.checkListVencimiento.CheckOnClick = true;
            this.checkListVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListVencimiento.FormattingEnabled = true;
            this.checkListVencimiento.Items.AddRange(new object[] {
            "NO VENCIDA",
            "1 - 30 Días",
            "31 - 60 Días",
            "61 - 90 Días",
            "+90 Días"});
            this.checkListVencimiento.Location = new System.Drawing.Point(12, 168);
            this.checkListVencimiento.Name = "checkListVencimiento";
            this.checkListVencimiento.Size = new System.Drawing.Size(201, 124);
            this.checkListVencimiento.TabIndex = 8;
            this.checkListVencimiento.SelectedValueChanged += new System.EventHandler(this.checkListVencimiento_SelectedValueChanged);
            // 
            // FormInformeCXCDetallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 603);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelFiltros);
            this.Name = "FormInformeCXCDetallado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformeCXCDetallado";
            this.Load += new System.EventHandler(this.FormInformeCXCDetallado_Load);
            this.Shown += new System.EventHandler(this.FormInformeCXCDetallado_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ListaCXCDBindingSource)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltros;
        private Bunifu.Framework.UI.BunifuFlatButton btnOcultarPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListaCXCDBindingSource;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkListVencimiento;
    }
}