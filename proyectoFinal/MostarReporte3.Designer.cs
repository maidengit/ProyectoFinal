namespace proyectoFinal
{
    partial class MostarReporte3
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
            this.spGradoAsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new proyectoFinal.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spListaGradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spListaGradoTableAdapter = new proyectoFinal.DataSetPrincipalTableAdapters.spListaGradoTableAdapter();
            this.spGradoAsignaturaTableAdapter = new proyectoFinal.DataSetPrincipalTableAdapters.spGradoAsignaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spGradoAsignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaGradoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spGradoAsignaturaBindingSource
            // 
            this.spGradoAsignaturaBindingSource.DataMember = "spGradoAsignatura";
            this.spGradoAsignaturaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spGradoAsignaturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyectoFinal.ReporteGradoAsignatura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 441);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spListaGradoBindingSource
            // 
            this.spListaGradoBindingSource.DataMember = "spListaGrado";
            this.spListaGradoBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spListaGradoTableAdapter
            // 
            this.spListaGradoTableAdapter.ClearBeforeFill = true;
            // 
            // spGradoAsignaturaTableAdapter
            // 
            this.spGradoAsignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // MostarReporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 441);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostarReporte3";
            this.Text = "MostarReporte3";
            this.Load += new System.EventHandler(this.MostarReporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGradoAsignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaGradoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGradoAsignaturaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private System.Windows.Forms.BindingSource spListaGradoBindingSource;
        private DataSetPrincipalTableAdapters.spListaGradoTableAdapter spListaGradoTableAdapter;
        private DataSetPrincipalTableAdapters.spGradoAsignaturaTableAdapter spGradoAsignaturaTableAdapter;
    }
}