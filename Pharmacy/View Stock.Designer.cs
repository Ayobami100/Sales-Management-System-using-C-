namespace Pharmacy
{
    partial class View_Stock
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.87531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12469F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.98245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.017544F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 470);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 20);
            this.textBox3.TabIndex = 23;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockId,
            this.stockName,
            this.stockPrice,
            this.stockQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(711, 443);
            this.dataGridView1.TabIndex = 11;
            // 
            // stockId
            // 
            this.stockId.DataPropertyName = "stockId";
            this.stockId.HeaderText = "Stock Id";
            this.stockId.Name = "stockId";
            this.stockId.Visible = false;
            // 
            // stockName
            // 
            this.stockName.DataPropertyName = "stockName";
            this.stockName.HeaderText = "Stock Name";
            this.stockName.Name = "stockName";
            // 
            // stockPrice
            // 
            this.stockPrice.DataPropertyName = "stockPrice";
            this.stockPrice.HeaderText = "Stock Price";
            this.stockPrice.Name = "stockPrice";
            // 
            // stockQuantity
            // 
            this.stockQuantity.DataPropertyName = "stockQuantity";
            this.stockQuantity.HeaderText = "Stock Quantity";
            this.stockQuantity.Name = "stockQuantity";
            // 
            // View_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "View_Stock";
            this.ShowIcon = false;
            this.Text = "View_Stock";
            this.Load += new System.EventHandler(this.View_Stock_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantity;
    }
}