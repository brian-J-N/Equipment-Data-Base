
namespace COMS_276_Program4
{
    partial class frmEquipment
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
            this.lstEquipment = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstPurchaseDate = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEquipmentReport = new System.Windows.Forms.Button();
            this.btEquipmentListReport = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lstEquipment
            // 
            this.lstEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquipment.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.lstEquipment, "List all equipment in data base.");
            this.lstEquipment.ItemHeight = 20;
            this.lstEquipment.Items.AddRange(new object[] {
            "123456789012345678901234567890"});
            this.lstEquipment.Location = new System.Drawing.Point(286, 95);
            this.lstEquipment.Name = "lstEquipment";
            this.helpProvider1.SetShowHelp(this.lstEquipment, true);
            this.lstEquipment.Size = new System.Drawing.Size(285, 424);
            this.lstEquipment.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.helpProvider1.SetHelpString(this.btnAdd, "Add a new item to equipment list");
            this.btnAdd.Location = new System.Drawing.Point(577, 95);
            this.btnAdd.Name = "btnAdd";
            this.helpProvider1.SetShowHelp(this.btnAdd, true);
            this.btnAdd.Size = new System.Drawing.Size(128, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.helpProvider1.SetHelpString(this.btnEdit, "Edit an existing item in the equipment list");
            this.btnEdit.Location = new System.Drawing.Point(577, 169);
            this.btnEdit.Name = "btnEdit";
            this.helpProvider1.SetShowHelp(this.btnEdit, true);
            this.btnEdit.Size = new System.Drawing.Size(128, 49);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.helpProvider1.SetHelpString(this.btnDelete, "Delete an item from the equipment list.");
            this.btnDelete.Location = new System.Drawing.Point(577, 241);
            this.btnDelete.Name = "btnDelete";
            this.helpProvider1.SetShowHelp(this.btnDelete, true);
            this.btnDelete.Size = new System.Drawing.Size(128, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstPurchaseDate
            // 
            this.lstPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchaseDate.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.lstPurchaseDate, "Display the purchase date.");
            this.lstPurchaseDate.ItemHeight = 20;
            this.lstPurchaseDate.Items.AddRange(new object[] {
            "11/01/1996"});
            this.lstPurchaseDate.Location = new System.Drawing.Point(66, 95);
            this.lstPurchaseDate.Name = "lstPurchaseDate";
            this.helpProvider1.SetShowHelp(this.lstPurchaseDate, true);
            this.lstPurchaseDate.Size = new System.Drawing.Size(214, 424);
            this.lstPurchaseDate.TabIndex = 4;
            this.lstPurchaseDate.SelectedIndexChanged += new System.EventHandler(this.lstPurchaseDate_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.helpProvider1.SetHelpString(this.btnExit, "Exit application.");
            this.btnExit.Location = new System.Drawing.Point(577, 474);
            this.btnExit.Name = "btnExit";
            this.helpProvider1.SetShowHelp(this.btnExit, true);
            this.btnExit.Size = new System.Drawing.Size(128, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.label1, "Label to identifiy the list as purchase date list.");
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchase Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.label2, "Label to identifty the equipment list.");
            this.label2.Location = new System.Drawing.Point(282, 60);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Equipment Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEquipmentReport
            // 
            this.helpProvider1.SetHelpString(this.btnEquipmentReport, "Display the selected item infomation on a report.");
            this.btnEquipmentReport.Location = new System.Drawing.Point(577, 314);
            this.btnEquipmentReport.Name = "btnEquipmentReport";
            this.helpProvider1.SetShowHelp(this.btnEquipmentReport, true);
            this.btnEquipmentReport.Size = new System.Drawing.Size(128, 51);
            this.btnEquipmentReport.TabIndex = 8;
            this.btnEquipmentReport.Text = "Equipment Report";
            this.btnEquipmentReport.UseVisualStyleBackColor = true;
            this.btnEquipmentReport.Click += new System.EventHandler(this.btnEquipmentReport_Click);
            // 
            // btEquipmentListReport
            // 
            this.helpProvider1.SetHelpString(this.btEquipmentListReport, "Display all items in the equipment list on a report.");
            this.btEquipmentListReport.Location = new System.Drawing.Point(577, 391);
            this.btEquipmentListReport.Name = "btEquipmentListReport";
            this.helpProvider1.SetShowHelp(this.btEquipmentListReport, true);
            this.btEquipmentListReport.Size = new System.Drawing.Size(128, 51);
            this.btEquipmentListReport.TabIndex = 9;
            this.btEquipmentListReport.Text = "Equipment List Report";
            this.btEquipmentListReport.UseVisualStyleBackColor = true;
            this.btEquipmentListReport.Click += new System.EventHandler(this.btEquipmentListReport_Click);
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 581);
            this.Controls.Add(this.btEquipmentListReport);
            this.Controls.Add(this.btnEquipmentReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstPurchaseDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstEquipment);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipment";
            this.Text = "Equipment Data Base";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstPurchaseDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEquipmentReport;
        private System.Windows.Forms.Button btEquipmentListReport;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

