namespace Hw5 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.siteNewDataTextBox = new System.Windows.Forms.TextBox();
            this.IDNewDataTextBox = new System.Windows.Forms.TextBox();
            this.passwordNewDataTextBox = new System.Windows.Forms.TextBox();
            this.enterIDNewDataLabel = new System.Windows.Forms.Label();
            this.enterSiteNewDataLabel = new System.Windows.Forms.Label();
            this.enterPasswordNewDataLabel = new System.Windows.Forms.Label();
            this.addNewDataButton = new System.Windows.Forms.Button();
            this.newDataGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.viewDataButton = new System.Windows.Forms.Button();
            this.siteNameSearchDataTextBox = new System.Windows.Forms.TextBox();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.siteNameSearchDataLabel = new System.Windows.Forms.Label();
            this.deleteDataGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordDeleteDataTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordDeleteDataLabel = new System.Windows.Forms.Label();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.IDDeleteDataTextBox = new System.Windows.Forms.TextBox();
            this.IDDeleteDataLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.modifyDataGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyDataButton = new System.Windows.Forms.Button();
            this.passwordModifyDataTextBox = new System.Windows.Forms.TextBox();
            this.enterPasswordModifyDataLabel = new System.Windows.Forms.Label();
            this.IDModifyDataTextBox = new System.Windows.Forms.TextBox();
            this.enterIDModifyDataLabel = new System.Windows.Forms.Label();
            this.viewPasswordButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearListBox = new System.Windows.Forms.Button();
            this.newDataGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.deleteDataGroupBox.SuspendLayout();
            this.modifyDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultListBox
            // 
            this.resultListBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 23;
            this.resultListBox.Location = new System.Drawing.Point(395, 265);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(640, 418);
            this.resultListBox.TabIndex = 0;
            // 
            // siteNewDataTextBox
            // 
            this.siteNewDataTextBox.Location = new System.Drawing.Point(228, 68);
            this.siteNewDataTextBox.Name = "siteNewDataTextBox";
            this.siteNewDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.siteNewDataTextBox.TabIndex = 1;
            // 
            // IDNewDataTextBox
            // 
            this.IDNewDataTextBox.Location = new System.Drawing.Point(228, 21);
            this.IDNewDataTextBox.Name = "IDNewDataTextBox";
            this.IDNewDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.IDNewDataTextBox.TabIndex = 2;
            // 
            // passwordNewDataTextBox
            // 
            this.passwordNewDataTextBox.Location = new System.Drawing.Point(228, 118);
            this.passwordNewDataTextBox.Name = "passwordNewDataTextBox";
            this.passwordNewDataTextBox.PasswordChar = '*';
            this.passwordNewDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.passwordNewDataTextBox.TabIndex = 3;
            // 
            // enterIDNewDataLabel
            // 
            this.enterIDNewDataLabel.AutoSize = true;
            this.enterIDNewDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterIDNewDataLabel.Location = new System.Drawing.Point(6, 22);
            this.enterIDNewDataLabel.Name = "enterIDNewDataLabel";
            this.enterIDNewDataLabel.Size = new System.Drawing.Size(190, 25);
            this.enterIDNewDataLabel.TabIndex = 4;
            this.enterIDNewDataLabel.Text = "Enter ID (1, 2, etc..): ";
            // 
            // enterSiteNewDataLabel
            // 
            this.enterSiteNewDataLabel.AutoSize = true;
            this.enterSiteNewDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterSiteNewDataLabel.Location = new System.Drawing.Point(6, 67);
            this.enterSiteNewDataLabel.Name = "enterSiteNewDataLabel";
            this.enterSiteNewDataLabel.Size = new System.Drawing.Size(165, 25);
            this.enterSiteNewDataLabel.TabIndex = 5;
            this.enterSiteNewDataLabel.Text = "Enter Site Name: ";
            // 
            // enterPasswordNewDataLabel
            // 
            this.enterPasswordNewDataLabel.AutoSize = true;
            this.enterPasswordNewDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterPasswordNewDataLabel.Location = new System.Drawing.Point(6, 119);
            this.enterPasswordNewDataLabel.Name = "enterPasswordNewDataLabel";
            this.enterPasswordNewDataLabel.Size = new System.Drawing.Size(160, 25);
            this.enterPasswordNewDataLabel.TabIndex = 6;
            this.enterPasswordNewDataLabel.Text = "Enter Password: ";
            // 
            // addNewDataButton
            // 
            this.addNewDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.addNewDataButton.Location = new System.Drawing.Point(269, 150);
            this.addNewDataButton.Name = "addNewDataButton";
            this.addNewDataButton.Size = new System.Drawing.Size(95, 87);
            this.addNewDataButton.TabIndex = 7;
            this.addNewDataButton.Text = "Add New Data";
            this.addNewDataButton.UseVisualStyleBackColor = true;
            this.addNewDataButton.Click += new System.EventHandler(this.addNewDataButton_Click);
            // 
            // newDataGroupBox
            // 
            this.newDataGroupBox.Controls.Add(this.enterIDNewDataLabel);
            this.newDataGroupBox.Controls.Add(this.addNewDataButton);
            this.newDataGroupBox.Controls.Add(this.passwordNewDataTextBox);
            this.newDataGroupBox.Controls.Add(this.siteNewDataTextBox);
            this.newDataGroupBox.Controls.Add(this.enterPasswordNewDataLabel);
            this.newDataGroupBox.Controls.Add(this.enterSiteNewDataLabel);
            this.newDataGroupBox.Controls.Add(this.IDNewDataTextBox);
            this.newDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.newDataGroupBox.Name = "newDataGroupBox";
            this.newDataGroupBox.Size = new System.Drawing.Size(377, 247);
            this.newDataGroupBox.TabIndex = 8;
            this.newDataGroupBox.TabStop = false;
            this.newDataGroupBox.Text = "New Data";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.viewDataButton);
            this.searchGroupBox.Controls.Add(this.siteNameSearchDataTextBox);
            this.searchGroupBox.Controls.Add(this.searchDataButton);
            this.searchGroupBox.Controls.Add(this.siteNameSearchDataLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(395, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(377, 153);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Data";
            // 
            // viewDataButton
            // 
            this.viewDataButton.Location = new System.Drawing.Point(142, 53);
            this.viewDataButton.Name = "viewDataButton";
            this.viewDataButton.Size = new System.Drawing.Size(95, 87);
            this.viewDataButton.TabIndex = 12;
            this.viewDataButton.Text = "View Site Names";
            this.viewDataButton.UseVisualStyleBackColor = true;
            this.viewDataButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // siteNameSearchDataTextBox
            // 
            this.siteNameSearchDataTextBox.Location = new System.Drawing.Point(235, 21);
            this.siteNameSearchDataTextBox.Name = "siteNameSearchDataTextBox";
            this.siteNameSearchDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.siteNameSearchDataTextBox.TabIndex = 1;
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(278, 53);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(93, 87);
            this.searchDataButton.TabIndex = 12;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            this.searchDataButton.Click += new System.EventHandler(this.searchDataButton_Click);
            // 
            // siteNameSearchDataLabel
            // 
            this.siteNameSearchDataLabel.AutoSize = true;
            this.siteNameSearchDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.siteNameSearchDataLabel.Location = new System.Drawing.Point(6, 22);
            this.siteNameSearchDataLabel.Name = "siteNameSearchDataLabel";
            this.siteNameSearchDataLabel.Size = new System.Drawing.Size(103, 25);
            this.siteNameSearchDataLabel.TabIndex = 0;
            this.siteNameSearchDataLabel.Text = "Enter Site:";
            // 
            // deleteDataGroupBox
            // 
            this.deleteDataGroupBox.Controls.Add(this.confirmPasswordDeleteDataTextBox);
            this.deleteDataGroupBox.Controls.Add(this.confirmPasswordDeleteDataLabel);
            this.deleteDataGroupBox.Controls.Add(this.deleteDataButton);
            this.deleteDataGroupBox.Controls.Add(this.IDDeleteDataTextBox);
            this.deleteDataGroupBox.Controls.Add(this.IDDeleteDataLabel);
            this.deleteDataGroupBox.Location = new System.Drawing.Point(12, 469);
            this.deleteDataGroupBox.Name = "deleteDataGroupBox";
            this.deleteDataGroupBox.Size = new System.Drawing.Size(377, 194);
            this.deleteDataGroupBox.TabIndex = 10;
            this.deleteDataGroupBox.TabStop = false;
            this.deleteDataGroupBox.Text = "Delete Data";
            // 
            // confirmPasswordDeleteDataTextBox
            // 
            this.confirmPasswordDeleteDataTextBox.Location = new System.Drawing.Point(228, 60);
            this.confirmPasswordDeleteDataTextBox.Name = "confirmPasswordDeleteDataTextBox";
            this.confirmPasswordDeleteDataTextBox.PasswordChar = '*';
            this.confirmPasswordDeleteDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.confirmPasswordDeleteDataTextBox.TabIndex = 4;
            // 
            // confirmPasswordDeleteDataLabel
            // 
            this.confirmPasswordDeleteDataLabel.AutoSize = true;
            this.confirmPasswordDeleteDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmPasswordDeleteDataLabel.Location = new System.Drawing.Point(6, 61);
            this.confirmPasswordDeleteDataLabel.Name = "confirmPasswordDeleteDataLabel";
            this.confirmPasswordDeleteDataLabel.Size = new System.Drawing.Size(177, 25);
            this.confirmPasswordDeleteDataLabel.TabIndex = 3;
            this.confirmPasswordDeleteDataLabel.Text = "Confirm Password:";
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Location = new System.Drawing.Point(269, 92);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(95, 87);
            this.deleteDataButton.TabIndex = 2;
            this.deleteDataButton.Text = "Delete Data";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // IDDeleteDataTextBox
            // 
            this.IDDeleteDataTextBox.Location = new System.Drawing.Point(228, 21);
            this.IDDeleteDataTextBox.Name = "IDDeleteDataTextBox";
            this.IDDeleteDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.IDDeleteDataTextBox.TabIndex = 1;
            // 
            // IDDeleteDataLabel
            // 
            this.IDDeleteDataLabel.AutoSize = true;
            this.IDDeleteDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IDDeleteDataLabel.Location = new System.Drawing.Point(6, 22);
            this.IDDeleteDataLabel.Name = "IDDeleteDataLabel";
            this.IDDeleteDataLabel.Size = new System.Drawing.Size(88, 25);
            this.IDDeleteDataLabel.TabIndex = 0;
            this.IDDeleteDataLabel.Text = "Enter ID:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(805, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 87);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // modifyDataGroupBox
            // 
            this.modifyDataGroupBox.Controls.Add(this.modifyDataButton);
            this.modifyDataGroupBox.Controls.Add(this.passwordModifyDataTextBox);
            this.modifyDataGroupBox.Controls.Add(this.enterPasswordModifyDataLabel);
            this.modifyDataGroupBox.Controls.Add(this.IDModifyDataTextBox);
            this.modifyDataGroupBox.Controls.Add(this.enterIDModifyDataLabel);
            this.modifyDataGroupBox.Location = new System.Drawing.Point(12, 265);
            this.modifyDataGroupBox.Name = "modifyDataGroupBox";
            this.modifyDataGroupBox.Size = new System.Drawing.Size(377, 198);
            this.modifyDataGroupBox.TabIndex = 11;
            this.modifyDataGroupBox.TabStop = false;
            this.modifyDataGroupBox.Text = "Modify Data";
            // 
            // modifyDataButton
            // 
            this.modifyDataButton.Location = new System.Drawing.Point(269, 98);
            this.modifyDataButton.Name = "modifyDataButton";
            this.modifyDataButton.Size = new System.Drawing.Size(95, 87);
            this.modifyDataButton.TabIndex = 12;
            this.modifyDataButton.Text = "Modify Data";
            this.modifyDataButton.UseVisualStyleBackColor = true;
            this.modifyDataButton.Click += new System.EventHandler(this.modifyDataButton_Click);
            // 
            // passwordModifyDataTextBox
            // 
            this.passwordModifyDataTextBox.Location = new System.Drawing.Point(228, 66);
            this.passwordModifyDataTextBox.Name = "passwordModifyDataTextBox";
            this.passwordModifyDataTextBox.PasswordChar = '*';
            this.passwordModifyDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.passwordModifyDataTextBox.TabIndex = 3;
            // 
            // enterPasswordModifyDataLabel
            // 
            this.enterPasswordModifyDataLabel.AutoSize = true;
            this.enterPasswordModifyDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterPasswordModifyDataLabel.Location = new System.Drawing.Point(6, 67);
            this.enterPasswordModifyDataLabel.Name = "enterPasswordModifyDataLabel";
            this.enterPasswordModifyDataLabel.Size = new System.Drawing.Size(204, 25);
            this.enterPasswordModifyDataLabel.TabIndex = 2;
            this.enterPasswordModifyDataLabel.Text = "Enter New Password: ";
            // 
            // IDModifyDataTextBox
            // 
            this.IDModifyDataTextBox.Location = new System.Drawing.Point(228, 21);
            this.IDModifyDataTextBox.Name = "IDModifyDataTextBox";
            this.IDModifyDataTextBox.Size = new System.Drawing.Size(136, 26);
            this.IDModifyDataTextBox.TabIndex = 1;
            // 
            // enterIDModifyDataLabel
            // 
            this.enterIDModifyDataLabel.AutoSize = true;
            this.enterIDModifyDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterIDModifyDataLabel.Location = new System.Drawing.Point(6, 22);
            this.enterIDModifyDataLabel.Name = "enterIDModifyDataLabel";
            this.enterIDModifyDataLabel.Size = new System.Drawing.Size(88, 25);
            this.enterIDModifyDataLabel.TabIndex = 0;
            this.enterIDModifyDataLabel.Text = "Enter ID:";
            // 
            // viewPasswordButton
            // 
            this.viewPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.viewPasswordButton.Location = new System.Drawing.Point(671, 171);
            this.viewPasswordButton.Name = "viewPasswordButton";
            this.viewPasswordButton.Size = new System.Drawing.Size(95, 89);
            this.viewPasswordButton.TabIndex = 8;
            this.viewPasswordButton.Text = "View Password (10 sec)";
            this.viewPasswordButton.UseVisualStyleBackColor = true;
            this.viewPasswordButton.Click += new System.EventHandler(this.viewPasswordButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(395, 171);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(95, 87);
            this.clearAllButton.TabIndex = 9;
            this.clearAllButton.Text = "Clear Text Boxes";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearListBox
            // 
            this.clearListBox.Location = new System.Drawing.Point(537, 171);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(95, 88);
            this.clearListBox.TabIndex = 13;
            this.clearListBox.Text = "Clear List Box";
            this.clearListBox.UseVisualStyleBackColor = true;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 686);
            this.Controls.Add(this.clearListBox);
            this.Controls.Add(this.viewPasswordButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.deleteDataGroupBox);
            this.Controls.Add(this.modifyDataGroupBox);
            this.Controls.Add(this.newDataGroupBox);
            this.Controls.Add(this.resultListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.newDataGroupBox.ResumeLayout(false);
            this.newDataGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.deleteDataGroupBox.ResumeLayout(false);
            this.deleteDataGroupBox.PerformLayout();
            this.modifyDataGroupBox.ResumeLayout(false);
            this.modifyDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.TextBox siteNewDataTextBox;
        private System.Windows.Forms.TextBox IDNewDataTextBox;
        private System.Windows.Forms.TextBox passwordNewDataTextBox;
        private System.Windows.Forms.Label enterIDNewDataLabel;
        private System.Windows.Forms.Label enterSiteNewDataLabel;
        private System.Windows.Forms.Label enterPasswordNewDataLabel;
        private System.Windows.Forms.Button addNewDataButton;
        private System.Windows.Forms.GroupBox newDataGroupBox;
        private System.Windows.Forms.Button viewPasswordButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox siteNameSearchDataTextBox;
        private System.Windows.Forms.Label siteNameSearchDataLabel;
        private System.Windows.Forms.GroupBox deleteDataGroupBox;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.TextBox IDDeleteDataTextBox;
        private System.Windows.Forms.Label IDDeleteDataLabel;
        private System.Windows.Forms.GroupBox modifyDataGroupBox;
        private System.Windows.Forms.TextBox passwordModifyDataTextBox;
        private System.Windows.Forms.Label enterPasswordModifyDataLabel;
        private System.Windows.Forms.TextBox IDModifyDataTextBox;
        private System.Windows.Forms.Label enterIDModifyDataLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button modifyDataButton;
        private System.Windows.Forms.TextBox confirmPasswordDeleteDataTextBox;
        private System.Windows.Forms.Label confirmPasswordDeleteDataLabel;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.Button viewDataButton;
        private System.Windows.Forms.Button clearListBox;
    }
}