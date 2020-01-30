using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pharmacy
{
    public partial class Fill_Stock : Form
    {
       
        Stock stock = new Stock();
        sale saley = new sale();

        public Fill_Stock()
        {
            InitializeComponent();
           // BindFirstGrid();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Fill_Stock_Load(object sender, EventArgs e)
        {
            populate();
        }

       

        void getDetailsFromDatatgridview()
        { 

        if (dataGridView1.CurrentRow.Index != -1)
            {
                stock.stockId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["stockId"].Value);
                using (DBEntities db = new DBEntities())
                {
                    stock = db.Stocks.Where(x => x.stockId == stock.stockId).FirstOrDefault();

                     txtName.Text = stock.stockName;
                    txtPrice.Text = stock.stockPrice;
                    txtQuantity.Text = stock.stockQuantity.ToString();
                }

            }
        }

        void populate()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Stocks.ToList<Stock>();
                //dataGridView1.ReadOnly = false;
            }
        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON IN ACTION
            txtName.Clear();
            txtPrice.Clear();
            dateTimePicker1.Refresh();
            txtQuantity.Clear();

            //TO ENABLE BUTTON ADD
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //UPDATE BUTTON IN ACTION
                using (DBEntities db = new DBEntities())
                {
                    int stockKey = Convert.ToInt32(dataGridView1.CurrentRow.Cells["stockId"].FormattedValue.ToString());
                    var result = db.Stocks.SingleOrDefault(b => b.stockId == stockKey);

                    if (result != null)
                    {
                        result.stockQuantity = Convert.ToInt32(txtQuantity.Text.Trim());
                        result.stockName = txtName.Text.Trim();
                        result.stockPrice = txtPrice.Text.Trim();

                        db.SaveChanges();
                        ////populate();
                    }


                }

                //LISTVIEW STARTS HERE
                var str = new string[3];
                str[0] = txtName.Text.ToUpper();
                str[1] = txtPrice.Text;
                str[2] = txtQuantity.Text;
                listView1.Items.Add(new ListViewItem(str));

                //AFTER INSERTING, CLEAR TEXTBOXES
                txtName.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();

                populate();
                MessageBox.Show("UPDATED SUCCESSFULLY");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var dbc = new DbContext();

                using (DBEntities db = new DBEntities())
                {
                    var isExist = db.Stocks.Where(a => a.stockName == txtName.Text.Trim()).FirstOrDefault();
                    if (isExist==null)
                    {
                        //INSERT BUTTON IN ACTION
                        stock.stockName = txtName.Text.Trim().ToUpper();
                        stock.stockPrice = txtPrice.Text.Trim();
                        stock.stockQuantity = Convert.ToInt32(txtQuantity.Text.Trim());

                        db.Stocks.Add(stock);
                        db.SaveChanges();

                        //LISTVIEW STARTS HERE
                        var str = new string[5];
                        str[0] = txtName.Text.ToUpper();
                        str[1] = txtPrice.Text;
                        str[2] = txtQuantity.Text;
                        listView1.Items.Add(new ListViewItem(str));

                        //AFTER INSERTING, CLEAR TEXTBOXES
                        txtName.Clear();
                        txtPrice.Clear();
                        txtQuantity.Clear();

                        populate();
                        MessageBox.Show("INSERTED SUCCESSFULLY");
                    }
                    else
                    {
                       if(MessageBox.Show("PRODUCT ALREADY EXIST, DO YOU WANT TO UPDATE IT?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            button2_Click(sender, e);
                        }
                        else
                        {
                            //AFTER INSERTING, CLEAR TEXTBOXES
                            txtName.Clear();
                            txtPrice.Clear();
                            txtQuantity.Clear();
                        }
                    }
                }
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[1].Value.ToString();
                if (!s.Contains(textBox5.Text))
                {
                    CurrencyManager cur = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    cur.SuspendBinding();
                    row.Visible = false;
                    cur.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            getDetailsFromDatatgridview();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getDetailsFromDatatgridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure to Delete this Record ?", " Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    using (DBEntities db = new DBEntities())
                    {

                        var entry = db.Entry(stock);

                        if (entry.State == EntityState.Detached)
                        {
                            db.Stocks.Attach(stock);
                            db.Stocks.Remove(stock);
                            db.SaveChanges();

                            populate();
                            MessageBox.Show("Deleted Successfully");
                        }

                    }

                    //CLEAR BUTTON IN ACTION
                    txtName.Clear();
                    txtPrice.Clear();
                    dateTimePicker1.Refresh();
                    txtQuantity.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = string.Format("{0:#,##0.00}", decimal.Parse(textBox2.Text));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

     

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }


       

        private void textBox1_Leave(object sender, EventArgs e)
        {
            txtName.Text.ToUpper();
            //textBox1.Text = string.Format("{0:#,##0.00}", decimal.Parse(textBox1.Text));
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(txtPrice.Text.Length >= 3)
            {
                txtPrice.Text = string.Format("{0:#,##0.00}", decimal.Parse(txtPrice.Text));
            }
          
        }
    }
}
