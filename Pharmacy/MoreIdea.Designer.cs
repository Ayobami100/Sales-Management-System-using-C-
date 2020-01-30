namespace Pharmacy
{
    partial class MoreIdea
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 488);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 488);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(68, 514);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 23);
            this.btnBack.TabIndex = 91;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 92;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 227);
            this.panel1.TabIndex = 93;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockId,
            this.stockName,
            this.stockPrice,
            this.stockQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(795, 200);
            this.dataGridView1.TabIndex = 90;
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
            this.stockName.HeaderText = "Product Name";
            this.stockName.Name = "stockName";
            this.stockName.Visible = false;
            // 
            // stockPrice
            // 
            this.stockPrice.DataPropertyName = "stockPrice";
            this.stockPrice.HeaderText = "Stock Price";
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Visible = false;
            // 
            // stockQuantity
            // 
            this.stockQuantity.DataPropertyName = "stockQuantity";
            this.stockQuantity.HeaderText = "Stock Quantity";
            this.stockQuantity.Name = "stockQuantity";
            this.stockQuantity.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtRep);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtAccName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtBill);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnOpenBill);
            this.panel3.Location = new System.Drawing.Point(7, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 101);
            this.panel3.TabIndex = 95;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(383, 47);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(299, 20);
            this.txtRep.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sales Rep. Name";
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(87, 47);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(194, 20);
            this.txtAccName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Account Name";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(87, 8);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bill Number";
            // 
            // btnOpenBill
            // 
            this.btnOpenBill.Location = new System.Drawing.Point(186, 6);
            this.btnOpenBill.Name = "btnOpenBill";
            this.btnOpenBill.Size = new System.Drawing.Size(24, 23);
            this.btnOpenBill.TabIndex = 0;
            this.btnOpenBill.Text = "---";
            this.btnOpenBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 77);
            this.panel2.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES INVOICE";
            // 
            // MoreIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MoreIdea";
            this.Text = "MoreIdea";
            this.Load += new System.EventHandler(this.MoreIdea_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantity;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}