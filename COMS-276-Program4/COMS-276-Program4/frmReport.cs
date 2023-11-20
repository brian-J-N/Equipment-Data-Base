using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS_276_Program4
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            EquipmentListReport(); // call the method to show equipment list report
        }

        public frmReport(int EquipID)
        {
            InitializeComponent();
            EquipmentReport(EquipID); // call the method to show equipment report
        }

        public void EquipmentListReport()
        {
            string strReportHeader;
            strReportHeader = "<HTML><HEAD><TITLE>Equipment List Report</TITLE></HEAD>";
            string strReportBody = "<BODY>";
            strReportBody += "<H1>Eqipment List Report</H1>";
            strReportBody += "<chr/>"; // horizontal line

            // create table to display content
            strReportBody += "<table>"; // create table
            strReportBody += "<tr>"; // create table row
            strReportBody += "<td><strong>Equipment Name</strong></td><td><strong>Purchase Date</strong><strong>Notes</strong></td>";// create cells
            strReportBody += "</td>";

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, EquipmentName, PurchaseDate, Notes FROM tblEquipment ORDER BY PurchaseDate";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                strReportBody += "<tr>"; // create new table row
                strReportBody += "<td>" + myData.dt.Rows[i]["EquipmentName"].ToString() + "</td>";
                strReportBody += "<td>" + myData.dt.Rows[i]["PurchaseDate"].ToString() + "</td>";
                strReportBody += "<td>" + myData.dt.Rows[i]["Notes"].ToString() + "</td>";
                strReportBody += "</tr>"; // close row
         
            }

            strReportBody += "</table>"; // close table
            strReportBody += "</body></html>"; // close report

            // display report in browser control
            webReport.DocumentText = strReportHeader + strReportBody;
        }
        

        public void EquipmentReport(int EquipmentID)
        {
            string strReportHeader;
            strReportHeader = "<HTML><HEAD><TITLE>Equipment Report</TITLE></HEAD>";
            string strReportBody = "<BODY>";
            strReportBody += "<H1>Eqipment Report</H1>";
            strReportBody += "<chr/>"; // horizontal line

            // get equipment info
            // connect to data
            clsData Item = new clsData();
            // pass sql to item
            Item.SQL = "SELECT ID, EquipmentName, PurchaseDate, Notes FROM tblEquipment WHERE ID = " + EquipmentID;

            // add item name to report
            strReportBody += "<br/>" + "Item Name: ";
            strReportBody += "<h2>" + Item.dt.Rows[0]["EquipmentName"].ToString() + "</h2>";
            strReportBody += "<br/>" + "Purchase Date: "; // add line break
            strReportBody += "<h2>" + Item.dt.Rows[0]["PurchaseDate"].ToString() + "</h2>";
            strReportBody += "<br/>"; // add line break
            strReportBody += "<strong>Notes: " + Item.dt.Rows[0]["Notes"].ToString() + "</strong>";

            // close report
            strReportBody += "</body></html>";

            // display in browser
            webReport.DocumentText = strReportHeader + strReportBody;

        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

   