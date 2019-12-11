using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pharmacy
{
    public partial class Fill_Stock : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True");
        SqlDataAdapter da;
        SqlDataReader dr;
        public Fill_Stock()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Fill_Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacySaleDataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.pharmacySaleDataSet1.Stock);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query = "select * from Stock where ProductID ='"+ @value+"'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox4.Text = dr["ProductID"].ToString();
                textBox3.Text= dr["ProductID"].ToString();
                textBox1.Text = dr["ProductName"].ToString();
                textBox2.Text = dr["Price"].ToString();
                numericUpDown1.Value = Convert.ToDecimal(dr["Quantity"]);
                //dateTimePicker1.Text = dr["ExpiryDate"].ToString();

            }
            con.Close();
            //TO DISABLE BUTTON ADD
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON IN ACTION
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Refresh();
            numericUpDown1.Refresh();

            //TO ENABLE BUTTON ADD
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE BUTTON IN ACTION
            con.Open();
            string query = "UPDATE Stock set Quantity ='" + numericUpDown1.Value.ToString() + "' , Price ='"+textBox2.Text+"'  WHERE ProductID ='"+textBox4.Text+"'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //LISTVIEW STARTS HERE
            var str = new string[5];
            str[0] = textBox1.Text.ToUpper();
            str[1] = textBox2.Text;
            str[2] = numericUpDown1.Value.ToString();
            str[3] = dateTimePicker1.Text;
            listView1.Items.Add(new ListViewItem(str));

            MessageBox.Show("UPDATED SUCCESSFULLY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT BUTTON IN ACTION
            string ProductName = textBox1.Text;
            string Price = textBox2.Text;
            string DateOfSale = dateTimePicker1.Text;
            string Quantity = numericUpDown1.Value.ToString();
            string ProductID = textBox4.Text;
            con.Open();
            string query = "INSERT INTO Stock(ProductName,Price,Quantity,ProductID) VALUES(@ProductName,@Price,@Quantity,@ProductID)";
            cmd = new SqlCommand(query, con);
           
            cmd.Parameters.AddWithValue("@ProductName",ProductName);
            cmd.Parameters.AddWithValue("@ProductID",ProductID);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
           // cmd.Parameters.AddWithValue("@DateOfSale", DateOfSale);

            cmd.ExecuteNonQuery();

            con.Close();

            //LISTVIEW STARTS HERE
            var str = new string[5];
            str[0] = textBox1.Text.ToUpper();
            str[1] = textBox2.Text;
            str[2] = numericUpDown1.Value.ToString();
            str[3] = dateTimePicker1.Text;
            str[4] = textBox4.Text;
            listView1.Items.Add(new ListViewItem (str));

            //AFTER INSERTING, CLEAR TEXTBOXES
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Refresh();
            numericUpDown1.Refresh();

            MessageBox.Show("INSERTED SUCCESSFULLY");
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[0].Value.ToString();
                if (!s.StartsWith(textBox5.Text, true, null))
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
    }
}
