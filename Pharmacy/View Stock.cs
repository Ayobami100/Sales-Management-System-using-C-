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
    public partial class View_Stock : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True");
        SqlDataAdapter da;
        SqlDataReader dr;
        public View_Stock()
        {
            InitializeComponent();
        }

        private void View_Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacySaleDataSet2.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.pharmacySaleDataSet2.Stock);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query = "select * from Stock where ProductID ='" + @value + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["ProductName"].ToString();
                textBox2.Text = dr["Price"].ToString();
                numericUpDown1.Value = Convert.ToDecimal(dr["Quantity"]);
               // dateTimePicker1.Text = dr["ExpiryDate"].ToString();

            }
            con.Close();
        }
    }
}
