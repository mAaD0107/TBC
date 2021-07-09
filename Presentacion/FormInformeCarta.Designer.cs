
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            reportDataSource1.Name = "InformacionCarta";
            reportDataSource1.Value = this.InformeCartaBindingSource;
            reportDataSource2.Name = "ListadoFacturas";
            reportDataSource2.Value = this.ListadoFacturasBindingSource;
            reportDataSource3.Name = "ListadoAbonos";
            reportDataSource3.Value = this.AbonosFacturasBindingSource;
            reportDataSource4.Name = "ListadoDevoluciones";
            reportDataSource4.Value = this.DevolucionSaldoBindingSource;
            reportDataSource5.Name = "ListadoTransferenciaOrigen";
            reportDataSource5.Value = this.TransferenciaOrigenBindingSource;
            reportDataSource6.Name = "ListadoTransferenciaDestino";
            reportDataSource6.Value = this.TransferenciaDestinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
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