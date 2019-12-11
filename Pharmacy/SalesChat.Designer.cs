namespace Pharmacy
{
    partial class SalesChat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pharmacySaleDataSet4 = new Pharmacy.PharmacySaleDataSet4();
            this.billingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingTableAdapter = new Pharmacy.PharmacySaleDataSet4TableAdapters.BillingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySaleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DAILY SALES",
            "WEEKLY SALES",
            "MONTHLY SALES ",
            "YEARLY SALES"});
            this.comboBox1.Location = new System.Drawing.Point(336, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 1;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.Perspective = 7;
            chartArea1.Area3DStyle.Rotation = 4;
            chartArea1.Area3DStyle.WallWidth = 17;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowOffset = 5;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.billingBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 109);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "0";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(825, 413);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // pharmacySaleDataSet4
            // 
            this.pharmacySaleDataSet4.DataSetName = "PharmacySaleDataSet4";
            this.pharmacySaleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingBindingSource
            // 
            this.billingBindingSource.DataMember = "Billing";
            this.billingBindingSource.DataSource = this.pharmacySaleDataSet4;
            // 
            // billingTableAdapter
            // 
            this.billingTableAdapter.ClearBeforeFill = true;
            // 
            // SalesChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 525);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox1);
            this.Name = "SalesChat";
            this.ShowIcon = false;
            this.Text = "SalesChat";
            this.Load += new System.EventHandler(this.SalesChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySaleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PharmacySaleDataSet4 pharmacySaleDataSet4;
        private System.Windows.Forms.BindingSource billingBindingSource;
        private PharmacySaleDataSet4TableAdapters.BillingTableAdapter billingTableAdapter;
    }
}