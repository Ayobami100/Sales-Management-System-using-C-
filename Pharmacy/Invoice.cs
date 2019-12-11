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
using System.IO;
using System.Collections;
using System.Drawing.Printing;
namespace Pharmacy
{
    public partial class Invoice : Form
    {

        #region Variables

        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        private PrintDocument _printDocument = new PrintDocument();
        private DataGridView gw = new DataGridView();
        public string _ReportHeader;


        #endregion

        public void ClsPrint(DataGridView gridview, string ReportHeader)
        {
            _printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            _printDocument.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            gw = gridview;
            _ReportHeader = ReportHeader;
        }


        public void PrintForm()
        {

            ////Open the print dialog
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = _printDocument;
            //printDialog.UseEXDialog = true;

            ////Get the document
            //if (DialogResult.OK == printDialog.ShowDialog())
            //{
            //    _printDocument.DocumentName = "Test Page Print";
            //    _printDocument.Print();
            //}

            //Open the print preview dialog


        }

        public Invoice()
        {
            InitializeComponent();
        }
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewComboBoxColumn combo1 = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn combo2 = new DataGridViewComboBoxColumn();
        DataGridTextBoxColumn serial = new DataGridTextBoxColumn();
        DataGridTextBoxColumn price = new DataGridTextBoxColumn();
        DataGridTextBoxColumn quantity = new DataGridTextBoxColumn();
        DataGridTextBoxColumn total = new DataGridTextBoxColumn();
        DataGridTextBoxColumn bn = new DataGridTextBoxColumn();

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private void Invoice_Load(object sender, EventArgs e)
        {
            //FOR CLOCK
            timer1.Start();



            serial.HeaderText = "S/N";
            serial.Width = 2;
            dataGridView1.Columns.Add("column1", "S/N");


            chk.HeaderText = "TRAY";
            chk.Width = 40;
            chk.FillWeight = 10;
            dataGridView1.Columns.Add(chk);


            combo1.HeaderText = "PRODUCT NAME";
            combo1.Width = 435;
            dataGridView1.Columns.Add(combo1);
            combo1.AutoComplete = true;

            cmd = new SqlCommand("Stocky", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                combo1.Items.Add(dr["ProductName"]);
            }

            con.Close();

            //combo2.HeaderText = "PACK";
            //combo2.Width = 200;
            //dataGridView1.Columns.Add(combo2);

            price.HeaderText = "PRICE";
            price.Width = 100;
            dataGridView1.Columns.Add("Column5", "PRICE");

            price.HeaderText = "QUANTITY";
            price.Width = 200;
            dataGridView1.Columns.Add("Column6", "QUANTITY");

            price.HeaderText = "TOTAL";
            price.Width = 300;
            dataGridView1.Columns.Add("Column7", "TOTAL");

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = 1;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[1].Value = true;
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            con.Open();

            string test = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            string value = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            string query = "select * from Stock where ProductName ='" + @value + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combo2.Items.Clear();
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = dr["Price"].ToString();
            }
            con.Close();

            //CALCULATE FOR TOTAL
            double price = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            double quantity = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            double total = price * quantity;

            dataGridView1.Rows[e.RowIndex].Cells[5].Value = total.ToString();

            //CALCUALTE FOR TOTAL PRICE AND TOTAL QUANTITY
            double final = 0;
            double quan = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                final += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                txtTotal.Text = final.ToString();

                quan += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                txtQuan.Text = quan.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    //THIS WILL RE-NUMBER THE ROW WHEN DELETED
                    int a = 1;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        row.Cells[1].Value = true;
                        row.Cells[0].Value = a;
                        a++;
                    }

                    //CALCUALTE SUMMATION OF PRICE AND QUANTITY
                    double final = 0;
                    double quan = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        final += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        txtTotal.Text = final.ToString();

                        quan += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        txtQuan.Text = quan.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THIS ROW CAN NOT BE DELETED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  DataTable dt = new DataTable();

            //  string[] prod = dt.AsEnumerable().Select(s => s.Field<string>("PRODUCT NAME")).ToArray<string>();
            //  for (int i = 0; i <= dataGridView1.Rows.Count; i++)
            //  {
            //      MessageBox.Show(prod[i]);
            //  }
            //  //INSERT BUTTON IN ACTION
            //  String BillNum = TextBill.Text;
            //  string[] ProductName = prod;
            ////  MessageBox.Show(Prod);
            //  string Price = textBox2.Text;
            //  string DateOfSale = DateTime.Now.ToString("dd-MMM-yyyy");
            //  //string Quantity = numericUpDown1.Value.ToString();
            //  con.Open();
            //  string query = "INSERT INTO Billing (BillNum,ProductName,Price,Quantity,DateOfSale) VALUES(@BillNum,@ProductName,@Price,@Quantity,@ExpiryDate)";
            //  cmd = new SqlCommand(query, con);
            //  cmd.ExecuteNonQuery();
            //  con.Close();
            ClsPrint(dataGridView1, "SALES INVOICE" + "  " + "Total Quantity Purchased: " + txtQuan.Text + "Total Amount:" + txtTotal.Text);            
            PrintDialog printDialog = new PrintDialog();
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                PrintPreviewDialog objPPdialog = new PrintPreviewDialog();

                _printDocument.Print();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
            //Set the top margin
            int iTopMargin = e.MarginBounds.Top;
            //Whether more pages have to print or not
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;

            //For the first page to print set the cell width and header height
            if (bFirstPage)
            {
                foreach (DataGridViewColumn GridCol in gw.Columns)
                {
                    iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                        (double)iTotalWidth * (double)iTotalWidth *
                        ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                    iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                    // Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin);
                    arrColumnWidths.Add(iTmpWidth);
                    iLeftMargin += iTmpWidth;
                }
            }
            //Loop till all the grid rows not get printed
            while (iRow <= gw.Rows.Count - 1)
            {
                DataGridViewRow GridRow = gw.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 0;
                //Check whether the current page settings allows more rows to print
                if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    bNewPage = true;
                    bFirstPage = false;
                    bMorePagesToPrint = true;
                    break;
                }
                else
                {

                    if (bNewPage)
                    {
                        //Draw Header
                        e.Graphics.DrawString(_ReportHeader,
                            new Font(gw.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader,
                            new Font(gw.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        //String strDate = "";
                        ////Draw Date
                        //e.Graphics.DrawString(strDate,
                        //    new Font(gw.Font, FontStyle.Bold), Brushes.Black,
                        //    e.MarginBounds.Left +
                        //    (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                        //    new Font(gw.Font, FontStyle.Bold),
                        //    e.MarginBounds.Width).Width),
                        //    e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader,
                        //    new Font(new Font(gw.Font, FontStyle.Bold),
                        //    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        DataGridViewColumn[] _GridCol = new DataGridViewColumn[gw.Columns.Count];
                        int colcount = gw.Columns.Count - 1;
                        //Convert ltr to rtl
                        foreach (DataGridViewColumn GridCol in gw.Columns)
                        {
                            _GridCol[colcount--] = GridCol;
                        }
                        for (int i = (_GridCol.Count() - 1); i >= 0; i--)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawString(_GridCol[i].HeaderText,
                                _GridCol[i].InheritedStyle.Font,
                                new SolidBrush(_GridCol[i].InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                            iCount++;
                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 0;
                    DataGridViewCell[] _GridCell = new DataGridViewCell[GridRow.Cells.Count];
                    int cellcount = GridRow.Cells.Count - 1;
                    //Convert ltr to rtl
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        _GridCell[cellcount--] = Cel;
                    }
                    //Draw Columns Contents                
                    for (int i = (_GridCell.Count() - 1); i >= 0; i--)
                    {
                        if (_GridCell[i].Value != null)
                        {
                            e.Graphics.DrawString(_GridCell[i].FormattedValue.ToString(),
                                _GridCell[i].InheritedStyle.Font,
                                new SolidBrush(_GridCell[i].InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount],
                                (float)iTopMargin,
                                (int)arrColumnWidths[iCount], (float)iCellHeight),
                                strFormat);
                        }
                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                            (int)arrColumnWidths[iCount], iCellHeight));
                        iCount++;
                    }
                }
                iRow++;
                iTopMargin += iCellHeight;
            }
            //If more lines exist, print another page.
            if (bMorePagesToPrint)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        public void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in gw.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

    
