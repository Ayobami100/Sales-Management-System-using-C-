using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class MoreIdea : Form
    {
        Form2 f2 = new Form2();
        public MoreIdea()
        {
            InitializeComponent();
           
        }
        void populate()
        {
            string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT saleName,salePrice,saleQuantity FROM sale",con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    con.Close();
                        
                }
            }
        }
        private void MoreIdea_Load(object sender, EventArgs e)
        {

            populate();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }
    }
}
