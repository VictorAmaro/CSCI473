/***********************************************************
CSCI 473 - Assignment 4 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: March 28, 2018

Purpose:  display a chart in a form and do some tricks with it: 
          adding values from different sources, changing the chart type, etc
************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign4 {
    public partial class Form1 : Form {
        List<double> fileList = new List<double>();   //store numbers in from file

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        /**************************************************
         * Use: 1) Closes form when the Exit button is clicked
         * ***********************************************/
        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /**************************************************
         * Use: 1) clear chart when the clear button is clicked
         * ***********************************************/
        private void clearButton_Click(object sender, EventArgs e) {
            myChart.Series[0].Points.Clear();
        }

        /**************************************************
         * Use: 1) checks which radio button has been pressed
         *          then changes the graph based on that
         ************************************************/
        private void radioButtons_CheckedChanged(object sender, EventArgs e) {
            if(pieChartButton.Checked) {
                myChart.Series[0].ChartType = SeriesChartType.Pie;
            }
            if(barChartButton.Checked) {
                myChart.Series[0].ChartType = SeriesChartType.Bar;
            }
            if(pointChartButton.Checked) {
                myChart.Series[0].ChartType = SeriesChartType.Point;
            }
            if(columnChartButton.Checked) {
                myChart.Series[0].ChartType = SeriesChartType.Column;
            }
        }

        /**************************************************
         * Use: 1) generates a number between 0.0 and 30.0
         *      2) adds it to the chart
         ************************************************/
        private void randoValButton_Click(object sender, EventArgs e) {
            Random rand = new Random();
            double randNum = Math.Round((rand.NextDouble() * ((30.0 - 0.0) + 0.0)), 2);        //generate random number

            myChart.Series[0].Points.AddY(randNum);                                           //add random number to chart
        }

        /**************************************************
         * Use: 1) attempts to parse the user input from the textbox into a double
         *          if it fails, displays message
         *          if it passes, checks if number is > 0.0 and < 30.0
         *              if fails, displays a message saying so
         *              if passes, adds the number to the chart
         ************************************************/
        private void userValButton_Click(object sender, EventArgs e) {
            double userDub;

            if (Double.TryParse(userNumberTextBox.Text, out userDub)) {                         //attempt to parse
                if (userDub < 0.0 || userDub > 30.0) {                                          //is between range?
                    MessageBox.Show("Number was out of range! Must be between 0.0 and 30.0!");  //no display message and dont add number to chart
                    return;
                }

                myChart.Series[0].Points.AddY(userDub);                                         //parse passed, add number to chart
            } else { 
                MessageBox.Show("Not a number! Please try again!");                             //parse failed, display message
            }           
        }

        /**************************************************
         * Use: 1) create new file dialog object
         *          set its directory to "."
         *      2) clear list in case anything left over
         *      3) show dialog
         *      4) open user file
         *      5) read from file into the list, converting the strings into doubles
         *      6) close use file
         ************************************************/
        private void chooseFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = ".";                                                //init directory
            fileList.Clear();                                                                 //clear list in case anything left over form last file

            if(fileDialog.ShowDialog() == DialogResult.OK) {                                  //show dialog
                StreamReader sr = new StreamReader(fileDialog.FileName);                      //open file

                string currentLine = sr.ReadLine();                                           //primary read
                while(currentLine != null) {                                                  //while there stuff in file
                    fileList.Add( Convert.ToDouble(currentLine));                             //convert to double and add it to list
                    currentLine = sr.ReadLine();                                              //next read
                }
                sr.Close();
            }

        }

        /**************************************************
         * Use: 1) attempt to add a point to chart from list
         *          if list is empty, catch exception, do nothing
         *      2) attempt to remove one item from list
         *          if list is empty, catch exception, do nothing
         ************************************************/
        private void valueFileButton_Click(object sender, EventArgs e) {
            try {
                myChart.Series[0].Points.AddY(fileList[0]);                          //add point
            } catch (Exception ex) {
                Console.WriteLine("(Nothing in file left, only here for testing)"); //empty list
            }


            try {
                fileList.RemoveAt(0);                                               //remove item
            }
            catch (Exception ex) {
                Console.WriteLine("(List is empty, only here for testing)");        //empty list
            }  
        }
    }
}
