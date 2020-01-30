namespace Pharmacy
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatagrid = new System.Windows.Forms.Panel();
            this.panelTextbox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDatagrid.SuspendLayout();
            this.panelTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNumber,
            this.repName,
            this.totalAmount,
            this.dateCreated,
            this.billId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(804, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // billNumber
            // 
            this.billNumber.DataPropertyName = "billNumber";
            this.billNumber.HeaderText = "Bill Number";
            this.billNumber.Name = "billNumber";
            // 
            // repName
            // 
            this.repName.DataPropertyName = "saleName";
            this.repName.HeaderText = "Rep Name";
            this.repName.Name = "repName";
            // 
            // totalAmount
            // 
            this.totalAmount.DataPropertyName = "totalAmount";
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            // 
            // dateCreated
            // 
            this.dateCreated.DataPropertyName = "dateCreated";
            this.dateCreated.HeaderText = "Date";
            this.dateCreated.Name = "dateCreated";
            // 
            // billId
            // 
            this.billId.DataPropertyName = "billId";
            this.billId.HeaderText = "Bill Id";
            this.billId.Name = "billId";
            this.billId.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Bill Number";
            // 
            // panelDatagrid
            // 
            this.panelDatagrid.Controls.Add(this.dataGridView1);
            this.panelDatagrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDatagrid.Location = new System.Drawing.Point(186, 0);
            this.panelDatagrid.Name = "panelDatagrid";
            this.panelDatagrid.Size = new System.Drawing.Size(804, 450);
            this.panelDatagrid.TabIndex = 3;
            // 
            // panelTextbox
            // 
            this.panelTextbox.Controls.Add(this.textBox1);
            this.panelTextbox.Controls.Add(this.label1);
            this.panelTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTextbox.Location = new System.Drawing.Point(0, 0);
            this.panelTextbox.Name = "panelTextbox";
            this.panelTextbox.Size = new System.Drawing.Size(180, 450);
            this.panelTextbox.TabIndex = 1;
            this.panelTextbox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTextbox_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.panelTextbox);
            this.Controls.Add(this.panelDatagrid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDatagrid.ResumeLayout(false);
            this.panelTextbox.ResumeLayout(false);
            this.panelTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn repName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDatagrid;
        private System.Windows.Forms.Panel panelTextbox;
    }
}