using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class View_Stock : Form
    {
        Stock stock = new Stock();
        public View_Stock()
        {
            InitializeComponent();
        }

       
        void populate()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Stocks.ToList<Stock>();

            }
        }



        private void View_Stock_Load(object sender, EventArgs e)
        {
            populate();
           
        }
      
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[1].Value.ToString();
                if (!s.Contains(textBox3.Text))
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
