namespace Assign2 {
    partial class Form1 {
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
            this.choicesGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.RadioButton();
            this.changeOfficeButton = new System.Windows.Forms.RadioButton();
            this.teleSearchButton = new System.Windows.Forms.RadioButton();
            this.officeSearchButton = new System.Windows.Forms.RadioButton();
            this.nameSearchButton = new System.Windows.Forms.RadioButton();
            this.addEntryButton = new System.Windows.Forms.RadioButton();
            this.printListButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.officeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.choicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // choicesGroupBox
            // 
            this.choicesGroupBox.Controls.Add(this.exitButton);
            this.choicesGroupBox.Controls.Add(this.clearButton);
            this.choicesGroupBox.Controls.Add(this.sortButton);
            this.choicesGroupBox.Controls.Add(this.changeOfficeButton);
            this.choicesGroupBox.Controls.Add(this.teleSearchButton);
            this.choicesGroupBox.Controls.Add(this.officeSearchButton);
            this.choicesGroupBox.Controls.Add(this.nameSearchButton);
            this.choicesGroupBox.Controls.Add(this.addEntryButton);
            this.choicesGroupBox.Controls.Add(this.printListButton);
            this.choicesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.choicesGroupBox.Name = "choicesGroupBox";
            this.choicesGroupBox.Size = new System.Drawing.Size(262, 314);
            this.choicesGroupBox.TabIndex = 0;
            this.choicesGroupBox.TabStop = false;
            this.choicesGroupBox.Text = "Choices";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(7, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 24);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(6, 242);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 24);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear All Entry Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // sortButton
            // 
            this.sortButton.AutoSize = true;
            this.sortButton.Location = new System.Drawing.Point(7, 212);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(132, 24);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Sort By Name";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // changeOfficeButton
            // 
            this.changeOfficeButton.AutoSize = true;
            this.changeOfficeButton.Location = new System.Drawing.Point(7, 181);
            this.changeOfficeButton.Name = "changeOfficeButton";
            this.changeOfficeButton.Size = new System.Drawing.Size(196, 24);
            this.changeOfficeButton.TabIndex = 5;
            this.changeOfficeButton.Text = "Change Office Number";
            this.changeOfficeButton.UseVisualStyleBackColor = true;
            this.changeOfficeButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // teleSearchButton
            // 
            this.teleSearchButton.AutoSize = true;
            this.teleSearchButton.Location = new System.Drawing.Point(7, 150);
            this.teleSearchButton.Name = "teleSearchButton";
            this.teleSearchButton.Size = new System.Drawing.Size(246, 24);
            this.teleSearchButton.TabIndex = 4;
            this.teleSearchButton.Text = "Search By Telephone Number";
            this.teleSearchButton.UseVisualStyleBackColor = true;
            this.teleSearchButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // officeSearchButton
            // 
            this.officeSearchButton.AutoSize = true;
            this.officeSearchButton.Location = new System.Drawing.Point(7, 119);
            this.officeSearchButton.Name = "officeSearchButton";
            this.officeSearchButton.Size = new System.Drawing.Size(213, 24);
            this.officeSearchButton.TabIndex = 3;
            this.officeSearchButton.Text = "Search By Office Number";
            this.officeSearchButton.UseVisualStyleBackColor = true;
            this.officeSearchButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.AutoSize = true;
            this.nameSearchButton.Location = new System.Drawing.Point(7, 88);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(153, 24);
            this.nameSearchButton.TabIndex = 2;
            this.nameSearchButton.Text = "Search By Name";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // addEntryButton
            // 
            this.addEntryButton.AutoSize = true;
            this.addEntryButton.Location = new System.Drawing.Point(7, 57);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(128, 24);
            this.addEntryButton.TabIndex = 1;
            this.addEntryButton.Text = "Add An Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // printListButton
            // 
            this.printListButton.AutoSize = true;
            this.printListButton.Location = new System.Drawing.Point(7, 26);
            this.printListButton.Name = "printListButton";
            this.printListButton.Size = new System.Drawing.Size(141, 24);
            this.printListButton.TabIndex = 0;
            this.printListButton.Text = "Print Entire List";
            this.printListButton.UseVisualStyleBackColor = true;
            this.printListButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(280, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Name:";
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(280, 73);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(158, 20);
            this.officeLabel.TabIndex = 2;
            this.officeLabel.Text = "Enter Office Number:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(280, 133);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(191, 20);
            this.telephoneLabel.TabIndex = 3;
            this.telephoneLabel.Text = "Enter Telephone Number:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(477, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // officeTextBox
            // 
            this.officeTextBox.Location = new System.Drawing.Point(477, 69);
            this.officeTextBox.Name = "officeTextBox";
            this.officeTextBox.Size = new System.Drawing.Size(100, 26);
            this.officeTextBox.TabIndex = 5;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(477, 131);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 26);
            this.telephoneTextBox.TabIndex = 6;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.FormattingEnabled = true;
            this.resultBox.ItemHeight = 19;
            this.resultBox.Location = new System.Drawing.Point(284, 361);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(539, 308);
            this.resultBox.TabIndex = 7;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(280, 329);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(204, 20);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Names and Office Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 697);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.officeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.choicesGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choicesGroupBox.ResumeLayout(false);
            this.choicesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox choicesGroupBox;
        private System.Windows.Forms.RadioButton sortButton;
        private System.Windows.Forms.RadioButton changeOfficeButton;
        private System.Windows.Forms.RadioButton teleSearchButton;
        private System.Windows.Forms.RadioButton officeSearchButton;
        private System.Windows.Forms.RadioButton nameSearchButton;
        private System.Windows.Forms.RadioButton addEntryButton;
        private System.Windows.Forms.RadioButton printListButton; 
        private System.Windows.Forms.RadioButton clearButton;
        private System.Windows.Forms.RadioButton exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox officeTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ListBox resultBox;
    }
}

