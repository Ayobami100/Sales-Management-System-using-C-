namespace Pharmacy
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBillDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnItemDel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenBill = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 74);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 27);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBillDel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtQuan);
            this.panel2.Controls.Add(this.btnItemDel);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Location = new System.Drawing.Point(3, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 73);
            this.panel2.TabIndex = 7;
            // 
            // btnBillDel
            // 
            this.btnBillDel.Location = new System.Drawing.Point(330, 3);
            this.btnBillDel.Name = "btnBillDel";
            this.btnBillDel.Size = new System.Drawing.Size(110, 52);
            this.btnBillDel.TabIndex = 5;
            this.btnBillDel.Text = "Delete Bill";
            this.btnBillDel.UseVisualStyleBackColor = true;
            this.btnBillDel.Click += new System.EventHandler(this.btnBillDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Quantity";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(918, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.MouseHover += new System.EventHandler(this.txtTotal_MouseHover);
            // 
            // txtQuan
            // 
            this.txtQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.Location = new System.Drawing.Point(688, 19);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.ReadOnly = true;
            this.txtQuan.Size = new System.Drawing.Size(118, 20);
            this.txtQuan.TabIndex = 3;
            // 
            // btnItemDel
            // 
            this.btnItemDel.Location = new System.Drawing.Point(9, 9);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(62, 38);
            this.btnItemDel.TabIndex = 1;
            this.btnItemDel.Text = "Delete Item";
            this.btnItemDel.UseVisualStyleBackColor = true;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(77, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumber,
            this.stockName,
            this.stockPrice,
            this.stockQuantity,
            this.stockTotal});
            this.dataGridView1.Location = new System.Drawing.Point(3, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 242);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // serialNumber
            // 
            this.serialNumber.FillWeight = 58.48171F;
            this.serialNumber.HeaderText = "S/N";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            // 
            // stockName
            // 
            this.stockName.DataPropertyName = "saleName";
            this.stockName.FillWeight = 273.402F;
            this.stockName.HeaderText = "PRODUCT NAME";
            this.stockName.Name = "stockName";
            // 
            // stockPrice
            // 
            this.stockPrice.DataPropertyName = "salePrice";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.stockPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.stockPrice.FillWeight = 50.76142F;
            this.stockPrice.HeaderText = "PRICE";
            this.stockPrice.Name = "stockPrice";
            // 
            // stockQuantity
            // 
            this.stockQuantity.DataPropertyName = "saleQuantity";
            dataGridViewCellStyle11.NullValue = null;
            this.stockQuantity.DefaultCellStyle = dataGridViewCellStyle11;
            this.stockQuantity.FillWeight = 51.15459F;
            this.stockQuantity.HeaderText = "QUANTITY";
            this.stockQuantity.Name = "stockQuantity";
            // 
            // stockTotal
            // 
            this.stockTotal.DataPropertyName = "saleTotal";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.stockTotal.DefaultCellStyle = dataGridViewCellStyle12;
            this.stockTotal.FillWeight = 66.20023F;
            this.stockTotal.HeaderText = "TOTAL";
            this.stockTotal.Name = "stockTotal";
            this.stockTotal.ReadOnly = true;
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
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 129);
            this.panel3.TabIndex = 8;
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
            this.btnOpenBill.Click += new System.EventHandler(this.button3_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBillDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnItemDel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenBill;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockTotal;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}