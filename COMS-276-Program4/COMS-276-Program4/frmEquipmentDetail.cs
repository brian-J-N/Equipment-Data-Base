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
    public partial class frmEquipmentDetail : Form
    {
        // create data table to update records
        DataTable dtUpdate;

        public frmEquipmentDetail()
        {
            InitializeComponent();
        }

        public frmEquipmentDetail(int EquipmentID)
        {
            InitializeComponent();
            LoadItem(EquipmentID); // load Equipment ID passed to form
        }


        private void frmEquipmentDetail_Load(object sender, EventArgs e)
        {

        }

        private void LoadItem (int ID)
        {
            // connect to data
            clsData Item = new clsData();
            // pass sql to item
            Item.SQL = "SELECT ID, EquipmentName, PurchaseDate, Notes FROM tblEquipment WHERE ID = " + ID;
            // get values from data table and dspay to screen
            txtItemName.Tag = ID.ToString(); // capture uniqe id 
            txtItemName.Text = Item.dt.Rows[0]["EquipmentName"].ToString();
            dtPurchaseDate.Text = Item.dt.Rows[0]["PurchaseDate"].ToString();
            txtNotes.Text = Item.dt.Rows[0]["Notes"].ToString();
            // get information for update
            dtUpdate = Item.dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate information
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Enter the item name.");
            }// end if
            else
            {
                // verify existing equipment
                if (txtItemName.Tag.ToString() != "N")
                {
                    clsData myUpdateData = new clsData();
                    // updae local data table
                    dtUpdate.Rows[0]["EquipmentName"] = txtItemName.Text;
                    dtUpdate.Rows[0]["PurchaseDate"] = dtPurchaseDate.Text;
                    dtUpdate.Rows[0]["Notes"] = txtNotes.Text;
                    // send update to database
                    myUpdateData.UpdateData(dtUpdate, "SELECT ID, EquipmentName, Notes, PurchaseDate FROM tblEquipment WHERE ID = " + int.Parse(txtItemName.Tag.ToString()));
                }// end if

                // assume next customer
                else
                {
                    // create new instance to data class
                    clsData myNewData = new clsData();
                    // call update metod passing values
                    myNewData.CreateEquipment(txtItemName.Text, dtPurchaseDate.Text, txtNotes.Text);

                }// end else

                // data update, close the form
                this.Close();

            }// end else
        }
    }
}
