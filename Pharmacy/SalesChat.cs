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
    public partial class SalesChat : Form
    {
        public SalesChat()
        {
            InitializeComponent();
        }

        private void SalesChat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacySaleDataSet4.Billing' table. You can move, or remove it, as needed.
            this.billingTableAdapter.Fill(this.pharmacySaleDataSet4.Billing);


        }
    }
}
