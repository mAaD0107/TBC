
namespace Presentacion
{
    partial class FormInformeCarta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InformeCartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbonosFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DevolucionSaldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransferenciaOrigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransferenciaDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InformeCartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonosFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionSaldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferenciaOrigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferenciaDestinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InformeCartaBindingSource
            // 
            this.InformeCartaBindingSource.DataSource = typeof(Domain.Carta.InformeCarta);
            // 
            // ListadoFacturasBindingSource
            // 
            this.ListadoFacturasBindingSource.DataSource = typeof(Domain.Carta.ListadoFacturas);
            // 
            // AbonosFacturasBindingSource
            // 
            this.AbonosFacturasBindingSource.DataSource = typeof(Domain.Carta.AbonosFacturas);
            // 
            // DevolucionSaldoBindingSource
            // 
            this.DevolucionSaldoBindingSource.DataSource = typeof(Domain.Carta.DevolucionSaldo);
            // 
            // TransferenciaOrigenBindingSource
            // 
            this.TransferenciaOrigenBindingSource.DataSource = typeof(Domain.Carta.TransferenciaOrigen);
            // 
            // TransferenciaDestinoBindingSource
            // 
            this.TransferenciaDestinoBindingSource.DataSource = typeof(Domain.Carta.TransferenciaDestino);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "InformacionCarta";
            reportDataSource7.Value = this.InformeCartaBindingSource;
            reportDataSource8.Name = "ListadoFacturas";
            reportDataSource8.Value = this.ListadoFacturasBindingSource;
            reportDataSource9.Name = "ListadoAbonos";
            reportDataSource9.Value = this.AbonosFacturasBindingSource;
            reportDataSource10.Name = "ListadoDevoluciones";
            reportDataSource10.Value = this.DevolucionSaldoBindingSource;
            reportDataSource11.Name = "ListadoTransferenciaOrigen";
            reportDataSource11.Value = this.TransferenciaOrigenBindingSource;
            reportDataSource12.Name = "ListadoTransferenciaDestino";
            reportDataSource12.Value = this.TransferenciaDestinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.InformeCarta1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(814, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormInformeCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 636);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInformeCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformeCarta";
            this.Load += new System.EventHandler(this.FormInformeCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformeCartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonosFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionSaldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferenciaOrigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferenciaDestinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InformeCartaBindingSource;
        private System.Windows.Forms.BindingSource ListadoFacturasBindingSource;
        private System.Windows.Forms.BindingSource AbonosFacturasBindingSource;
        private System.Windows.Forms.BindingSource DevolucionSaldoBindingSource;
        private System.Windows.Forms.BindingSource TransferenciaOrigenBindingSource;
        private System.Windows.Forms.BindingSource TransferenciaDestinoBindingSource;
    }
}