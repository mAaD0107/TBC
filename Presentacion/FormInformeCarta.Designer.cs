
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
            this.listadoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformeCartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoAbonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informeCartaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.listadoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeCartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAbonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeCartaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoFacturasBindingSource
            // 
            this.listadoFacturasBindingSource.DataMember = "listadoFacturas";
            this.listadoFacturasBindingSource.DataSource = this.InformeCartaBindingSource;
            // 
            // InformeCartaBindingSource
            // 
            this.InformeCartaBindingSource.DataSource = typeof(Domain.Carta.InformeCarta);
            // 
            // listadoAbonoBindingSource
            // 
            this.listadoAbonoBindingSource.DataMember = "listadoAbono";
            this.listadoAbonoBindingSource.DataSource = this.informeCartaBindingSource1;
            // 
            // informeCartaBindingSource1
            // 
            this.informeCartaBindingSource1.DataSource = typeof(Domain.Carta.InformeCarta);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListadoFacturas";
            reportDataSource1.Value = this.listadoFacturasBindingSource;
            reportDataSource2.Name = "InformacionCarta";
            reportDataSource2.Value = this.InformeCartaBindingSource;
            reportDataSource3.Name = "ListadoAbonos";
            reportDataSource3.Value = this.listadoAbonoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.InformeCarta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(814, 636);
            this.reportViewer1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.listadoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeCartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAbonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeCartaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InformeCartaBindingSource;
        private System.Windows.Forms.BindingSource listadoFacturasBindingSource;
        private System.Windows.Forms.BindingSource informeCartaBindingSource1;
        private System.Windows.Forms.BindingSource listadoAbonoBindingSource;
    }
}