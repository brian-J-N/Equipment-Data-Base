
namespace COMS_276_Program4
{
    partial class frmEquipmentDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.lblItemName, "Label to identify the equipment name.");
            this.lblItemName.Location = new System.Drawing.Point(46, 138);
            this.lblItemName.Name = "lblItemName";
            this.helpProvider1.SetShowHelp(this.lblItemName, true);
            this.lblItemName.Size = new System.Drawing.Size(106, 24);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.txtItemName, "Enter an item name here.");
            this.txtItemName.Location = new System.Drawing.Point(183, 133);
            this.txtItemName.MaxLength = 30;
            this.txtItemName.Name = "txtItemName";
            this.helpProvider1.SetShowHelp(this.txtItemName, true);
            this.txtItemName.Size = new System.Drawing.Size(342, 30);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.Tag = "N";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.txtNotes, "Enter any comments or details about the item.");
            this.txtNotes.Location = new System.Drawing.Point(183, 195);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.helpProvider1.SetShowHelp(this.txtNotes, true);
            this.txtNotes.Size = new System.Drawing.Size(342, 141);
            this.txtNotes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.label1, "label to add any notes.");
            this.label1.Location = new System.Drawing.Point(88, 195);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.dtPurchaseDate, "Select the day, month, and year.");
            this.dtPurchaseDate.Location = new System.Drawing.Point(183, 67);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.helpProvider1.SetShowHelp(this.dtPurchaseDate, true);
            this.dtPurchaseDate.Size = new System.Drawing.Size(342, 30);
            this.dtPurchaseDate.TabIndex = 0;
            this.dtPurchaseDate.Value = new System.DateTime(2021, 2, 5, 16, 8, 20, 0);
            // 
            // btnUpdate
            // 
            this.helpProvider1.SetHelpString(this.btnUpdate, "When button is clicked the selected item information will be updated.");
            this.btnUpdate.Location = new System.Drawing.Point(183, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.helpProvider1.SetShowHelp(this.btnUpdate, true);
            this.btnUpdate.Size = new System.Drawing.Size(146, 59);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.helpProvider1.SetHelpString(this.btnCancel, "When button is clicked this form cancels any changes and closes.");
            this.btnCancel.Location = new System.Drawing.Point(379, 352);
            this.btnCancel.Name = "btnCancel";
            this.helpProvider1.SetShowHelp(this.btnCancel, true);
            this.btnCancel.Size = new System.Drawing.Size(146, 59);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.label2, "Label to identify the purchase date.");
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Purchase Date:";
            // 
            // frmEquipmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtPurchaseDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipmentDetail";
            this.Text = "Equipment Details";
            this.Load += new System.EventHandler(this.frmEquipmentDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}