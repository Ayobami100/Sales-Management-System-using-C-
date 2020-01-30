using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            populate();
        }


        void populate()
        {
            using (DBEntities db = new DBEntities())
            {
                var result = 
                (from b in db.bills
                 join c in db.billSales
                 on b.billNumber equals c.billINumber
                 select new
                 {
                     b.billNumber,
                     b.billId,
                     c.saleName,
                     c.totalAmount,
                     c.dateCreated
                 }).ToList();

                dataGridView1.DataSource = result;
                dataGridView1.Refresh();

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            Invoice vc = new Invoice();
            string billNumber = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();

            string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";


                using (SqlConnection con = new SqlConnection(constring))
                {
                //MessageBox.Show(billNumber);
                    using (SqlCommand cmd = new SqlCommand("SELECT saleName,salePrice,saleQuantity,saleTotal,repName,totalQuantity,totalAmount,billNumber FROM sale WHERE billNumber = '"+billNumber+"'", con))
                    {
                        con.Open();
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.CommandType = CommandType.Text;
                    //DataTable dt = new DataTable();
                    //dt.Load(cmd.ExecuteReader());
                    //vc.dataGridView1.AutoGenerateColumns = false;
                    //vc.dataGridView1.DataSource = dt;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            vc.txtBill.Text = dr["billNumber"].ToString();
                            vc.txtQuan.Text = dr["totalQuantity"].ToString();
                            vc.txtRep.Text = dr["repName"].ToString();
                            vc.txtTotal.Text = dr["totalAmount"].ToString();
                        }

                    }

                    cmd.BeginExecuteReader();
                        con.Close();
                    
                    }
                }
            

            vc.Show();
            this.Hide();

        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[0].Value.ToString();
                if(!s.Contains(textBox1.Text))
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panelTextbox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
