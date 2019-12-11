using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Pharmacy
{
    class ClsPrint
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
        private string _ReportHeader;

    

    public ClsPrint(DataGridView gridview, string ReportHeader)
    {
        _printDocument.PrintPage += new PrintPageEventHandler(_printDocument_PrintPage);
        _printDocument.BeginPrint += new PrintEventHandler(_printDocument_BeginPrint);
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
        PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
        objPPdialog.Document = _printDocument;
        objPPdialog.ShowDialog();
    }

}
#endregion