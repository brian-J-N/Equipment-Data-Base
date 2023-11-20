using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;// import data
using System.Data.OleDb; // import data
using System.IO; // import

namespace COMS_276_Program4
{
    public partial class frmEquipment : Form
    {
        //List to be parallel to listbox of equipment containing id
        List<int> intEquipmentID = new List<int>();
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            LoadEquipment(); // load 
        }

        // method to load data into lstEquipment
        private void LoadEquipment()
        {
            // clear out list box
            lstEquipment.Items.Clear();
            lstPurchaseDate.Items.Clear();
            // clear out list
            intEquipmentID.Clear();
            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, EquipmentName, PurchaseDate, Notes FROM tblEquipment ORDER BY PurchaseDate";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                lstEquipment.Items.Add(myData.dt.Rows[i]["EquipmentName"].ToString());

                // add date to lstDatePurchased
                lstPurchaseDate.Items.Add(myData.dt.Rows[i]["PurchaseDate"].ToString());

                // add equipment ID to list
                intEquipmentID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));
            }


        }// end method




        private void lstEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create instance of second form
            frmEquipmentDetail NewDetailForm = new frmEquipmentDetail();
            NewDetailForm.ShowDialog(); // show form
            LoadEquipment();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // make sure something was selected
            if (lstEquipment.SelectedIndex > -1)
            {
                // display to screen
                //MessageBox.Show(intEquipmentID[lstEquipment.SelectedIndex].ToString());
                // create instance of the second form
                frmEquipmentDetail EquipmentDetailForm = new frmEquipmentDetail(intEquipmentID[lstEquipment.SelectedIndex]);
                EquipmentDetailForm.ShowDialog(); // show equipment detail
                                                  // refresh list box
                LoadEquipment();
            }
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // verify that a racord was selected
            if (lstEquipment.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Record to Be Deleted.");
            }
            else
            {
                // verify that the user wants to delete record
                DialogResult res = MessageBox.Show(this, "Are you sure you want to delete " + lstEquipment.SelectedItem.ToString()
                    + "?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //delete record
                    // create instance of data class
                    clsData DeleteData = new clsData();
                    //delete record based on SQL
                    DeleteData.DeleteRecord("DELETE * FROM tblEquipment WHERE ID = " + intEquipmentID[lstEquipment.SelectedIndex]);
                    // refresh list box
                    LoadEquipment();

                }// end if
            }// end else
        }

        private void lstPurchaseDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipmentReport_Click(object sender, EventArgs e)
        {
            // make sure something was selected
            if (lstEquipment.SelectedIndex > -1)
            {
                // display to screen
                //MessageBox.Show(intEquipmentID[lstEquipment.SelectedIndex].ToString());
                // create instance of the second form
                frmReport EquipmentReport = new frmReport(intEquipmentID[lstEquipment.SelectedIndex]);
                EquipmentReport.ShowDialog(); // show equipment detail
                                              // refresh list box
                LoadEquipment();
            }
            else
            {
                // no equipment selected
                MessageBox.Show("Select an item to view the report");
            }
        }

        private void btEquipmentListReport_Click(object sender, EventArgs e)
        {
            // make sure there are customers to display
            if (lstEquipment.Items.Count > 0)
            {
                // create instance of form
                frmReport EquipmentListReport = new frmReport();
                // display report
                EquipmentListReport.ShowDialog();
            }
            else
            {
                // no equipment in list, throw error
                MessageBox.Show("there is no equipment to report.");
            }
        }
    }
}

