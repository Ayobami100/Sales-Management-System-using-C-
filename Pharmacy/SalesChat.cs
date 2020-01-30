using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("saleChart", con))
                {
                    con.Open();
                    //SqlDataReader reader = cmd.ExecuteReader();
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;

                    con.Close();

                }
            }

            if (dataGridView1.DataSource != null)
            {
                chart1.Series["Present"].Points.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart1.Series["Present"].Points.AddXY(dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[1].Value);

                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("saleChartYear", con))
                    {
                        con.Open();
                        //SqlDataReader reader = cmd.ExecuteReader();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView1.DataSource = dt;

                        con.Close();

                    }
                }

                if (dataGridView1.DataSource != null)
                {
                    chart1.Series["Present"].Points.Clear();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        this.chart1.Series["Present"].Points.AddXY(dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[1].Value);

                    }

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {

                string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("saleChartMonth", con))
                    {
                        con.Open();
                        //SqlDataReader reader = cmd.ExecuteReader();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView1.DataSource = dt;

                        con.Close();

                    }
                }

                if (dataGridView1.DataSource != null)
                {
                    chart1.Series["Present"].Points.Clear();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        this.chart1.Series["Present"].Points.AddXY(dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[1].Value);

                    }

                }
            }

            if (comboBox1.SelectedIndex == 2)
            {

                string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("saleChartWeek", con))
                    {
                        con.Open();
                        //SqlDataReader reader = cmd.ExecuteReader();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView1.DataSource = dt;

                        con.Close();

                    }
                }

                if (dataGridView1.DataSource != null)
                {
                    chart1.Series["Present"].Points.Clear();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        this.chart1.Series["Present"].Points.AddXY(dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[1].Value);

                    }

                }
            }
        }
    }
}
