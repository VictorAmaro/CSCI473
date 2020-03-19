/***********************************************************
CSCI 473 - Assignment 5 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: April 16, 2018

Purpose: Asks user to enter master password to view second form
    gets master password from text file
************************************************************/
using System;
using System.Windows.Forms;
using System.IO;

namespace Hw5 {
    public partial class Form1 : Form {
        Form2 mainForm = new Form2();
        public const Int32 MASTER_PASS_KEY = 9;    //key to decrypt master password from file 

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        /*******************************************
        * Clears the text box for user when clicked
        *******************************************/
        private void clearButton_Click(object sender, EventArgs e) {
            passwordTxtBox.Text = String.Empty;
        }

        private void enterButton_Click(object sender, EventArgs e) {
            string encryptedUser = CaesarCipher.encrypt(passwordTxtBox.Text.ToString(), MASTER_PASS_KEY);   //encrypt user input to compare

            if(encryptedUser.Equals(openFile())) {                                            //password match
                mainForm.Show();                                                            //show second form
                this.Visible = false;                                                       //hide this one
            } else {                                                                        //password didnt match
                MessageBox.Show("You Entered The Wrong Password! (bestPasswordEver123)");
            }
        }

        /*************************************
        * openFile()
        * arguments: none
        * returns: a string, the encrypted password from the file
        * use: opens the file that holds the password,
        *   then returns the encrypted password from the file
        ************************************/
        private string openFile() {
            try {
                StreamReader inFile = new StreamReader("superSecretMasterPassword.txt");  //open file

                string passwordFromFile = inFile.ReadLine();  //get first (and only) line form file
                inFile.Close();                               //close file

                return passwordFromFile;                      //return the string (password) from the file
            } catch(Exception e) {                            //someting happened, exit program
                Console.WriteLine("Couldn't find superSecretMasterPassword.txt");
                Application.Exit();

                return "";
            } 
        }

        /*******************************************
        * Exits program when clicked
        *******************************************/
        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}