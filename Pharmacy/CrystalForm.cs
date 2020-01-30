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
    public partial class CrystalForm : Form
    {
        public CrystalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 objRpt;
            objRpt = new CrystalReport1();
            DataSet ds = new DataSet();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataSet Ds = new DataSet();
                    ds.Tables.Add(dt);
                    objRpt.SetDataSource(Ds);
                }
            }
        }
    }
}
