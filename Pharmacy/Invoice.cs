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
using System.Data.Entity;

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
        Stock stock = new Stock();
        sale saley = new sale();
        bill billy = new bill();
        billSale bls = new billSale();
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        int[] SN = new int[1000];
        string[] ProductName = new string[1000];
        double[] Price = new double[1000];
        int[] Quantity = new int[1000];
        double[] sum = new double[1000];
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

            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                _printDocument.DocumentName = "Test Page Print";
                _printDocument.Print();
            }

            //Open the print preview dialog


        }
        private void Invoice_Load(object sender, EventArgs e)
        {

            timer1.Start();
            generateBill();
        }
        public Invoice()
        {
            InitializeComponent();
        }

        void sequenceNumber()
        {
            try
            {
                int i = 1;


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //row.Cells[1].Value = true;
                    row.Cells[0].Value = i;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void calculateTotal()
        {
            try
            {
                //CALCUALTE SUMMATION OF PRICE AND QUANTITY
                double final = 0;
                double quan = 0;

                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    if (dataGridView1.Rows[k].Cells[3].FormattedValue != "")
                    {
                        quan += Convert.ToDouble(dataGridView1.Rows[k].Cells[3].Value);
                        final += Convert.ToDouble(dataGridView1.Rows[k].Cells[4].Value);

                        // MessageBox.Show(quan.ToString());

                        txtQuan.Text = quan.ToString();
                        txtTotal.Text = final.ToString();

                        txtTotal.Text = string.Format("{0:#,##0}", double.Parse(txtTotal.Text));
                    }                        
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        void generateBill()
        {
            using (DBEntities db = new DBEntities())
            {
                
                int maxBill = db.bills.Select(p => p.billId).DefaultIfEmpty(0).Max();

                var getBillNumber = db.bills.Where(x => x.billId == maxBill).FirstOrDefault();

                string[] split = getBillNumber.billNumber.Split('-');
                int getBillNumberAdd = Convert.ToInt32(split[1]);
                getBillNumberAdd++;
                txtBill.Text = "CSR - " + getBillNumberAdd;
            }
                
        }


        public bool checkBillExist()
        {

            using (DBEntities db = new DBEntities())
            {
                 var checkBill = db.bills.Where(x => x.billNumber == txtBill.Text.Trim()).FirstOrDefault();
                if (checkBill == null)
                    return false;
                else
                    return true;
            }
        }
        void clearGridView()
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                    while (dataGridView1.Rows.Count == 0)
                        continue;
                }

                txtQuan.Text = "";
                txtTotal.Text = "";
                txtAccName.Text = "";
                txtRep.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void updateBillSale(string itf)
        {
            using (DBEntities db = new DBEntities())
            {
                //UPDATE TOTAL AMOUNT AFTER DELETE ON BILL SALE TABLE
                var resultBillSale = db.billSales.SingleOrDefault(a => a.billINumber == txtBill.Text.Trim());
                string hh = resultBillSale.totalAmount.Replace(",", "");
                int totalAmty = Convert.ToInt32(hh);

                //CONVERT TOTAL AMOUNT TO INT

                if (resultBillSale != null)
                {
                    totalAmty = totalAmty - Convert.ToInt32(itf);
                    resultBillSale.totalAmount = totalAmty.ToString();
                    db.SaveChanges();
                }
            }
         

        }

        void updateSaleQandT()
        {
            int getstockQuantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString());
            int txtQ = Convert.ToInt32(txtQuan.Text.Trim());
            int finalQ = txtQ - getstockQuantity;


            string getSaleTotal = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            int totalAmt = Convert.ToInt32(getSaleTotal);
            int txtT = Convert.ToInt32(txtTotal.Text.Trim().Replace(",", ""));
            int finalT = txtT - totalAmt;

            string constring = @"Data Source=DESKTOP-18J3HJ4;Initial Catalog=PharmacySale;Integrated Security=True";


            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE sale SET totalQuantity ="+ finalQ + " , totalAmount ="+ finalT +"WHERE billNumber = " + txtBill.Text.Trim() + "", con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }


        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            sequenceNumber();

            //CALCULATE TOTAL PRICE AND QUANTITY FOR THE TEXTBOXES
            //calculateTotal();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string productName = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();

                if (dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() != "")
                {
                    ///LOAD THE PRICE OF THE SELECTED PRODUCT
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            stock = db.Stocks.Where(x => x.stockName == productName).FirstOrDefault();

                            dataGridView1.CurrentRow.Cells[2].Value = stock.stockPrice;

                        }



                    }



                    //CALCUALTE GRIDVIEW FOR TOTAL PRICE AND TOTAL QUANTITY

                    if (dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString() != "")
                    {
                        double final = 0;
                        double quan = 0;
                        double total = 0;

                        double price = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
                        double quantity = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value);

                        total = price * quantity;
                        dataGridView1.CurrentRow.Cells[4].Value = total.ToString();

                        
                    }

                    ///CHECK IF SELECTED PRODUCT IS OUT OF STOCK
                    ///
                    if (dataGridView1.CurrentCell.ColumnIndex == 3)
                    {
                        string productQuantity = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
                        string totalAmount = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
                        //string productName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                        using (DBEntities db = new DBEntities())
                        {

                            stock = db.Stocks.Where(x => x.stockName == productName).FirstOrDefault();

                            if (productQuantity != "")
                            {
                                //MessageBox.Show(stock.stockQuantity.ToString());
                                if (stock.stockQuantity < Convert.ToDecimal(productQuantity))
                                {
                                    MessageBox.Show("OUT OF STOCK!");
                                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                                    //THIS WILL RE-NUMBER THE ROW WHEN DELETED


                                }

                            }
                        }
                    }
                }
                calculateTotal();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count >= 0)
                {
                    if (checkBillExist() == false)
                    {

                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                        //THIS WILL RE-NUMBER THE ROW WHEN DELETED
                        sequenceNumber();
                        calculateTotal();

                    }
                    else
                    {

                        if (MessageBox.Show("Are You Sure to Delete this Record ?", " Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string getProductName = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
                            int getstockQuantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString());
                            string getSaleTotal = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();

                            var itemToRemove = new object();

                            using (DBEntities db = new DBEntities())
                            {
                                itemToRemove = db.sales.Where(x => x.billNumber == txtBill.Text.Trim() && x.saleName == getProductName).FirstOrDefault(); //returns a single item.
                               var itemToRemove1 = db.sales.Where(x => x.billNumber == txtBill.Text.Trim() && x.saleName == getProductName).FirstOrDefault(); ;
                                //ITEM WILL BE REMOVED FROM DATABASE

                                db.sales.Remove(itemToRemove1);
                                db.SaveChanges();
                                sequenceNumber();
                                calculateTotal();
                            }

                            if (itemToRemove != null)
                             {

                                using (DBEntities db = new DBEntities())
                                {
                                    //UPDATE STOCK QUANTITY AFTER DELETE ON STOCK TABLE

                                    var result = db.Stocks.SingleOrDefault(b => b.stockName == getProductName);

                                    if (result != null)
                                    {
                                        result.stockQuantity += getstockQuantity;

                                        db.SaveChanges();
                                    }

                                }

                                updateSaleQandT();
                                updateBillSale(getSaleTotal);



                                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                            }
                            else
                            {
                                //REMOVE ITEM FROM DATAGRIDVIEW NOT FROM DATABASE 

                                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                                sequenceNumber();
                                calculateTotal();
                            }


                            
                        }

                    }
                }



            }
            catch (Exception ex)
            {
                //MessageBox.Show("THIS ROW CAN NOT BE DELETED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }

        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                BeginInvoke(new Action(() =>
                {

                    string productName = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();

                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {


                        using (DBEntities db = new DBEntities())
                        {
                            var v = from s in db.Stocks
                                    select s.stockName;
                            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                            source.AddRange(v.ToArray());


                            TextBox txtBusID = e.Control as TextBox;
                            if (txtBusID != null)
                            {
                                txtBusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                                txtBusID.AutoCompleteCustomSource = source;
                                txtBusID.AutoCompleteSource = AutoCompleteSource.CustomSource;


                            }



                        }

                    }

                    e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                    if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3) //Desired Column
                    {
                        TextBox tb = e.Control as TextBox;
                        if (tb != null)
                        {
                            tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                        }
                    }
                }));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            AdminLogIn ad = new AdminLogIn();
            ad.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string vim = txtBill.Text.Trim();
            try
            {
                if (checkBillExist() == false)
                {
                    //INSERT Bill Number into the database

                    billy.billNumber = vim;
                    using (DBEntities db = new DBEntities())
                    {
                        db.bills.Add(billy);
                        db.SaveChanges();

                    }



                    //using (DBEntities db = new DBEntities())
                    //{
                    //    billy = db.bills.Where(x => x.billNumber == vim).FirstOrDefault();
                    //}


                    //INSERT INTO BILL SALES 

                    bls.saleName = txtRep.Text;
                    bls.totalAmount = txtTotal.Text;
                    bls.billINumber = vim;


                    using (DBEntities db = new DBEntities())
                    {
                        db.billSales.Add(bls);
                        db.SaveChanges();

                    }


                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        //THIS WILL DEDUCT THE SOLD QUANTITY FROM STOCK QUANTITY AND UPDATE THE DATABASE

                        string productName = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                   //     int billNum = Convert.ToInt32(vim);

                        using (DBEntities db = new DBEntities())
                        {

                            var updateQuery = (from stock in db.Stocks
                                               where stock.stockName == productName
                                               select stock).FirstOrDefault();




                            if (updateQuery.stockQuantity > 0)
                            {
                                updateQuery.stockQuantity -= Convert.ToInt32(dataGridView1.Rows[i].Cells[3].FormattedValue);
                                //  MessageBox.Show(updateQuery.stockQuantity.ToString());
                                db.SaveChanges();
                            }
                        }
                        //////////////////////////////////////////////////////////////////


                        //SAVE DATAGRIDVIEW TO THE SALES DATABASE 

                        using (DBEntities db = new DBEntities())
                        {
                            var getStockId = (from stock in db.Stocks
                                              where stock.stockName == productName
                                              select stock).FirstOrDefault();



                            saley.saleName = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                            saley.salePrice = dataGridView1.Rows[i].Cells[2].FormattedValue.ToString();
                            saley.saleQuantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].FormattedValue);
                            saley.saleTotal = dataGridView1.Rows[i].Cells[4].FormattedValue.ToString();
                            saley.stockId = getStockId.stockId;
                            saley.billNumber = vim;
                            saley.totalAmount = txtTotal.Text;
                            saley.totalQuantity = Convert.ToInt32(txtQuan.Text);
                            saley.repName = txtRep.Text;


                            db.sales.Add(saley);
                            db.SaveChanges();


                        }

                    }
                    clearGridView();
                    sequenceNumber();
                    generateBill();
                    MessageBox.Show("SOLD!!");
                }
                else
                {
                    //UPDATE TOTAL AMOUNT IN THE BILL SALES

                    using (DBEntities db = new DBEntities())
                    {
                        var result = db.billSales.SingleOrDefault(b => b.billINumber == txtBill.Text.Trim());

                        if (result != null)
                        {
                            result.totalAmount = txtTotal.Text.Trim();

                            db.SaveChanges();
                        }


                    }

                    //DELETE ALL ROWS IN THE SALES TABLE ONE BY ONE

                   
                    int getstockQuantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString());
                    string getSaleTotal = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();

                    var itemToRemove = new object();

                    using (DBEntities db = new DBEntities())
                    {
                        //itemToRemove = db.sales.Where(x => x.billNumber == txtBill.Text.Trim() && x.saleName == getProductName).FirstOrDefault(); //returns a single item.
                        var itemToRemove1 = db.sales.Where(x => x.billNumber == txtBill.Text.Trim()); 
                        //ITEM WILL BE REMOVED FROM DATABASE

                        db.sales.RemoveRange(itemToRemove1);
                        db.SaveChanges();
                        sequenceNumber();
                        calculateTotal();
                    }

                      

                    //INSERT THE NEW ROWS INTO THE SALE DATABASE AFRESH

                    for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
                    {
                        string productName = dataGridView1.Rows[k].Cells[1].FormattedValue.ToString();
                        using (DBEntities db = new DBEntities())
                        {
                            var getStockId = (from stock in db.Stocks
                                                where stock.stockName == productName
                                                select stock).FirstOrDefault();



                            saley.saleName = dataGridView1.Rows[k].Cells[1].FormattedValue.ToString();
                            saley.salePrice = dataGridView1.Rows[k].Cells[2].FormattedValue.ToString();
                            saley.saleQuantity = Convert.ToInt32(dataGridView1.Rows[k].Cells[3].FormattedValue);
                            saley.saleTotal = dataGridView1.Rows[k].Cells[4].FormattedValue.ToString();
                            saley.stockId = getStockId.stockId;
                            saley.billNumber = vim;
                            saley.totalAmount = txtTotal.Text;
                            saley.totalQuantity = Convert.ToInt32(txtQuan.Text);
                            saley.repName = txtRep.Text;


                            db.sales.Add(saley);
                            db.SaveChanges();


                        }
                       
                    }
                    clearGridView();
                    sequenceNumber();
                    generateBill();
                    MessageBox.Show("THIS ITEMS WILL BE UPDATED!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ClsPrint(dataGridView1, "SALES INVOICE" + "  " + "Total Quantity Purchased: " + txtQuan.Text +"  "+ "Total Amount:" + txtTotal.Text);
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


       

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            sequenceNumber();
        }

      
        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            //CALCULATE TOTAL PRICE AND QUANTITY FOR THE TEXTBOXES
            //calculateTotal();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //CALCULATE TOTAL PRICE AND QUANTITY FOR THE TEXTBOXES
            //calculateTotal();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                View_Stock vs = new View_Stock();
                vs.Show();
                return true;
            }
            if (keyData == (Keys.Control | Keys.I))
            {
               Invoice iv = new Invoice();
                iv.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void btnBillDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, you want to Delete the bill ?", " Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //itemToRemove = new object();

                using (DBEntities db = new DBEntities())
                {
                    var itemToRemove = db.bills.Where(x => x.billNumber == txtBill.Text.Trim()).FirstOrDefault(); //returns a single item.
                    if (itemToRemove != null)
                    {
                        db.bills.Remove(itemToRemove);
                        db.SaveChanges();
                    }
                  
                }
                clearGridView();
                sequenceNumber();
                generateBill();

            }
        }

        private void txtTotal_MouseHover(object sender, EventArgs e)
        {
            calculateTotal();
        }
    }
}

    
