namespace Assign4 {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userNumberTextBox = new System.Windows.Forms.TextBox();
            this.userNumberLabel = new System.Windows.Forms.Label();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.pointChartButton = new System.Windows.Forms.RadioButton();
            this.barChartButton = new System.Windows.Forms.RadioButton();
            this.columnChartButton = new System.Windows.Forms.RadioButton();
            this.pieChartButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.userValButton = new System.Windows.Forms.Button();
            this.valueFileButton = new System.Windows.Forms.Button();
            this.randoValButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // myChart
            // 
            chartArea3.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.myChart.Legends.Add(legend3);
            this.myChart.Location = new System.Drawing.Point(387, 180);
            this.myChart.Name = "myChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.Points.Add(dataPoint9);
            this.myChart.Series.Add(series3);
            this.myChart.Size = new System.Drawing.Size(670, 536);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "barChart";
            // 
            // userNumberTextBox
            // 
            this.userNumberTextBox.Location = new System.Drawing.Point(208, 9);
            this.userNumberTextBox.Name = "userNumberTextBox";
            this.userNumberTextBox.Size = new System.Drawing.Size(120, 26);
            this.userNumberTextBox.TabIndex = 1;
            // 
            // userNumberLabel
            // 
            this.userNumberLabel.AutoSize = true;
            this.userNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.userNumberLabel.Name = "userNumberLabel";
            this.userNumberLabel.Size = new System.Drawing.Size(190, 20);
            this.userNumberLabel.TabIndex = 2;
            this.userNumberLabel.Text = "Enter a number for chart: ";
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.pointChartButton);
            this.radioGroupBox.Controls.Add(this.barChartButton);
            this.radioGroupBox.Controls.Add(this.columnChartButton);
            this.radioGroupBox.Controls.Add(this.pieChartButton);
            this.radioGroupBox.Location = new System.Drawing.Point(16, 452);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(312, 264);
            this.radioGroupBox.TabIndex = 3;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Chart Type";
            // 
            // pointChartButton
            // 
            this.pointChartButton.AutoSize = true;
            this.pointChartButton.Location = new System.Drawing.Point(7, 223);
            this.pointChartButton.Name = "pointChartButton";
            this.pointChartButton.Size = new System.Drawing.Size(113, 24);
            this.pointChartButton.TabIndex = 3;
            this.pointChartButton.TabStop = true;
            this.pointChartButton.Text = "Point Chart";
            this.pointChartButton.UseVisualStyleBackColor = true;
            this.pointChartButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // barChartButton
            // 
            this.barChartButton.AutoSize = true;
            this.barChartButton.Location = new System.Drawing.Point(7, 161);
            this.barChartButton.Name = "barChartButton";
            this.barChartButton.Size = new System.Drawing.Size(102, 24);
            this.barChartButton.TabIndex = 2;
            this.barChartButton.TabStop = true;
            this.barChartButton.Text = "Bar Chart";
            this.barChartButton.UseVisualStyleBackColor = true;
            this.barChartButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // columnChartButton
            // 
            this.columnChartButton.AutoSize = true;
            this.columnChartButton.Location = new System.Drawing.Point(7, 93);
            this.columnChartButton.Name = "columnChartButton";
            this.columnChartButton.Size = new System.Drawing.Size(183, 24);
            this.columnChartButton.TabIndex = 1;
            this.columnChartButton.TabStop = true;
            this.columnChartButton.Text = "Column Chart Button";
            this.columnChartButton.UseVisualStyleBackColor = true;
            this.columnChartButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // pieChartButton
            // 
            this.pieChartButton.AutoSize = true;
            this.pieChartButton.Location = new System.Drawing.Point(7, 26);
            this.pieChartButton.Name = "pieChartButton";
            this.pieChartButton.Size = new System.Drawing.Size(99, 24);
            this.pieChartButton.TabIndex = 0;
            this.pieChartButton.TabStop = true;
            this.pieChartButton.Text = "Pie Chart";
            this.pieChartButton.UseVisualStyleBackColor = true;
            this.pieChartButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(221, 307);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 104);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 105);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(16, 53);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(107, 104);
            this.chooseFileButton.TabIndex = 6;
            this.chooseFileButton.Text = "Choose a file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // userValButton
            // 
            this.userValButton.Location = new System.Drawing.Point(16, 176);
            this.userValButton.Name = "userValButton";
            this.userValButton.Size = new System.Drawing.Size(107, 107);
            this.userValButton.TabIndex = 7;
            this.userValButton.Text = "Value from user";
            this.userValButton.UseVisualStyleBackColor = true;
            this.userValButton.Click += new System.EventHandler(this.userValButton_Click);
            // 
            // valueFileButton
            // 
            this.valueFileButton.Location = new System.Drawing.Point(221, 53);
            this.valueFileButton.Name = "valueFileButton";
            this.valueFileButton.Size = new System.Drawing.Size(107, 104);
            this.valueFileButton.TabIndex = 8;
            this.valueFileButton.Text = "Value from file";
            this.valueFileButton.UseVisualStyleBackColor = true;
            this.valueFileButton.Click += new System.EventHandler(this.valueFileButton_Click);
            // 
            // randoValButton
            // 
            this.randoValButton.Location = new System.Drawing.Point(221, 177);
            this.randoValButton.Name = "randoValButton";
            this.randoValButton.Size = new System.Drawing.Size(107, 104);
            this.randoValButton.TabIndex = 9;
            this.randoValButton.Text = "Value at random";
            this.randoValButton.UseVisualStyleBackColor = true;
            this.randoValButton.Click += new System.EventHandler(this.randoValButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 728);
            this.Controls.Add(this.randoValButton);
            this.Controls.Add(this.valueFileButton);
            this.Controls.Add(this.userValButton);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.userNumberLabel);
            this.Controls.Add(this.userNumberTextBox);
            this.Controls.Add(this.myChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.TextBox userNumberTextBox;
        private System.Windows.Forms.Label userNumberLabel;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton pointChartButton;
        private System.Windows.Forms.RadioButton barChartButton;
        private System.Windows.Forms.RadioButton columnChartButton;
        private System.Windows.Forms.RadioButton pieChartButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button userValButton;
        private System.Windows.Forms.Button valueFileButton;
        private System.Windows.Forms.Button randoValButton;
    }
}

