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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.billingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacySaleDataSet4 = new Pharmacy.PharmacySaleDataSet4();
            this.billingTableAdapter = new Pharmacy.PharmacySaleDataSet4TableAdapters.BillingTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySaleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 9;
            chartArea2.Area3DStyle.Inclination = 1;
            chartArea2.Area3DStyle.Rotation = 4;
            chartArea2.Area3DStyle.WallWidth = 17;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowOffset = 5;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Present";
            series2.YValueMembers = "0";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(754, 474);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // billingBindingSource
            // 
            this.billingBindingSource.DataMember = "Billing";
            this.billingBindingSource.DataSource = this.pharmacySaleDataSet4;
            // 
            // pharmacySaleDataSet4
            // 
            this.pharmacySaleDataSet4.DataSetName = "PharmacySaleDataSet4";
            this.pharmacySaleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingTableAdapter
            // 
            this.billingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleMade,
            this.amountMade,
            this.Dt});
            this.dataGridView1.Location = new System.Drawing.Point(763, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(234, 521);
            this.dataGridView1.TabIndex = 2;
            // 
            // saleMade
            // 
            this.saleMade.DataPropertyName = "saleMade";
            this.saleMade.HeaderText = "Total Sales Made";
            this.saleMade.Name = "saleMade";
            this.saleMade.ReadOnly = true;
            // 
            // amountMade
            // 
            this.amountMade.DataPropertyName = "amountMade";
            this.amountMade.HeaderText = "Total Amount Made";
            this.amountMade.Name = "amountMade";
            this.amountMade.ReadOnly = true;
            // 
            // Dt
            // 
            this.Dt.DataPropertyName = "Dt";
            this.Dt.HeaderText = "Date Of Sales";
            this.Dt.Name = "Dt";
            this.Dt.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By Year",
            "By Month",
            "By Week"});
            this.comboBox1.Location = new System.Drawing.Point(156, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SalesChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 536);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "SalesChat";
            this.ShowIcon = false;
            this.Text = "SalesChat";
            this.Load += new System.EventHandler(this.SalesChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacySaleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PharmacySaleDataSet4 pharmacySaleDataSet4;
        private System.Windows.Forms.BindingSource billingBindingSource;
        private PharmacySaleDataSet4TableAdapters.BillingTableAdapter billingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleMade;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountMade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}