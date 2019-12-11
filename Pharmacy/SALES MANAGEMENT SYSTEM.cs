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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void aDMINISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fillStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fill_Stock fillstock = new Fill_Stock();
            fillstock.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Stock viewstock = new View_Stock();
            viewstock.Show();
        }

        private void salesChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesChat saleschat = new SalesChat();
            saleschat.Show();
        }

        private void iNVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Show();
        }
    }
}
