namespace CapaPresentacion
{
    partial class MostrarReporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Cantidad_MafiososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new CapaPresentacion.DataSet1();
            this.Juez_CasoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Juez_CasoTableAdapter = new CapaPresentacion.DataSet1TableAdapters.Juez_CasoTableAdapter();
            this.Cantidad_MafiososTableAdapter = new CapaPresentacion.DataSet1TableAdapters.Cantidad_MafiososTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_MafiososBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juez_CasoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Juez_CasoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportejuez.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(485, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // Cantidad_MafiososBindingSource
            // 
            this.Cantidad_MafiososBindingSource.DataMember = "Cantidad_Mafiosos";
            this.Cantidad_MafiososBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Juez_CasoBindingSource
            // 
            this.Juez_CasoBindingSource.DataMember = "Juez_Caso";
            this.Juez_CasoBindingSource.DataSource = this.DataSet1;
            // 
            // Juez_CasoTableAdapter
            // 
            this.Juez_CasoTableAdapter.ClearBeforeFill = true;
            // 
            // Cantidad_MafiososTableAdapter
            // 
            this.Cantidad_MafiososTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarReporte";
            this.Text = "MostrarReporte";
            this.Load += new System.EventHandler(this.MostrarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_MafiososBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juez_CasoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Juez_CasoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Juez_CasoTableAdapter Juez_CasoTableAdapter;
        private System.Windows.Forms.BindingSource Cantidad_MafiososBindingSource;
        private DataSet1TableAdapters.Cantidad_MafiososTableAdapter Cantidad_MafiososTableAdapter;
    }
}