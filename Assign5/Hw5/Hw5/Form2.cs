/***********************************************************
CSCI 473 - Assignment 5 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: April 16, 2018

Purpose: a small application dealing with passwords
************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hw5 {
    public partial class Form2 : Form {
        public const Int32 PASS_KEY = 4;    //key to decrypt passwords from file 
        Timer myTimer = new Timer();        //new timer 
        public static List<Account> accountList = new List<Account>();   //Create list of Account

        public Form2() {
            InitializeComponent();
            myTimer.Tick += new EventHandler(myTimerTick);             //set event handler for timer
        }

        private void Form2_Load(object sender, EventArgs e) {
            loadList();

            Console.WriteLine("***** Here for grading only *****");
            foreach (var account in accountList) {
                Console.WriteLine(account.IdNumber + "->" + CaesarCipher.decrypt(account.Password, PASS_KEY));
            }
        }

        /***************************************
         * loadList()
         * returns: nothing
         * arguments: none
         * use: Open file and store all site info from it into a List of Accounts
         ***************************************/ 
        private void loadList() {
            String inLine, 
                pattern = @" ";       //set regex pattern to a space

            try {
                StreamReader inFile = new StreamReader("totallySafeWayToKeepPasswords.txt");  //open txt file that holds site info

                inLine = inFile.ReadLine();                                                   //primary read
                while(inLine != null) {                                                       //while file has data
                    String[] spilts = Regex.Split(inLine, pattern);                           //store the line grabbed from file, seperated by spaces, into a string array

                    stringTrim(spilts);                                                       //trim

                    accountList.Add(new Account(spilts[0], spilts[1], spilts[2]));           //create a new Account object and store it into the List
                                                                                             //[0] is the ID number
                                                                                             //[1] is the site name
                                                                                             //[2] is the password

                    inLine = inFile.ReadLine();                                              //next read
                }
                inFile.Close();                                                              //close file
            }
            catch(Exception e) {                                                             //couldnt find file, exit
                Console.WriteLine("Couldn't find totallySafeWayToKeepPasswords.txt");
                Application.Exit();
            }
        }

        /**********************************
         * Makes sure what user entered (ID, Site, Password) is valid,
         *      then add all that to a new object of the accountList
         * Displays messages as needed
         **********************************/ 
        private void addNewDataButton_Click(object sender, EventArgs e) {
            string inID = IDNewDataTextBox.Text;            //bring in text box data
            string inSite = siteNewDataTextBox.Text;
            string inPass = passwordNewDataTextBox.Text;

            if((String.IsNullOrEmpty(inID)) || (String.IsNullOrEmpty(inSite))) {  //make sure no empty string for ID or site
                resultListBox.Items.Add("No empty fields are allowed!");
                resultListBox.Items.Add(" ");
                return;
            }

            if(!searchForID(inID)) {                         //ID doesnt exist, continue
                var tupleRes = searchDataWork(inSite);       //only using the first return, which returns if site exists or not
                if(!tupleRes.Item1) {                        //site doesnt exist, continue
                    if(passwordReqCheck(inPass)) {           //password passes reqs
                        accountList.Add(new Account(inID, inSite, CaesarCipher.encrypt(inPass, PASS_KEY))); //add new object to accountList
                        resultListBox.Items.Add("Entry added!");
                        resultListBox.Items.Add(" ");
                    } else {                                 //couldnt add password
                        passwordMessage();
                    }
                } else {                                     //site exists, dont continue
                    resultListBox.Items.Add("Sorry, site " + inSite + " already exists!");
                    resultListBox.Items.Add(" ");
                }
            } else {                                         //ID exists, dont continue
                resultListBox.Items.Add("Sorry, ID " + inID + " already exists!");
                resultListBox.Items.Add(" ");
            }
        }

        /***********************************
         *  passwordMessage()
         *  returns: nothing
         *  arguments: none
         *  use: prints out message when password fails
         **********************************/
        private void passwordMessage() {
            resultListBox.Items.Add("Sorry, that password isnt strong enough!");
            resultListBox.Items.Add("Passwords must be at least 8 characters,");
            resultListBox.Items.Add("Contain 1 uppercaser AND 1 lowercase letter,");
            resultListBox.Items.Add("And contain at least 1 digit ");
            resultListBox.Items.Add(" ");
        }

        /*******************************************
        * Clears all text boxes for user when clicked
        *******************************************/
        private void clearAllButton_Click(object sender, EventArgs e) {
            Action<Control.ControlCollection> lambda = null;

            lambda = (inControls) => {                         //lambda time
                foreach(Control cycleControl in inControls) {  //cycle thru all Controls
                    if(cycleControl is TextBox) {              //Control was a text box, clear is
                       (cycleControl as TextBox).Clear();
                    } else {                                   //Control wasnt a text box
                        lambda(cycleControl.Controls);
                    }
                }
            };
            lambda(Controls);
        }

        /*************************************
         * Makes sure user entered a valid Id, and a valid password as well, 
         *      then updates password w/ the given one from the user.
         * Displays any messages as needed
         *************************************/ 
        private void modifyDataButton_Click(object sender, EventArgs e) {
            string inID = IDModifyDataTextBox.Text;            //bring in text box data
            string inPass = passwordModifyDataTextBox.Text;    //bring in text box data

            if (searchForID(inID)) {                                    //ID was found
                if(passwordReqCheck(inPass)) {                          //user entered password meets reqs
                    for(int i = 0; i < accountList.Count; i++) {        //cycle thru accountList
                        if (accountList[i].IdNumber.Equals(inID)) {     //user entered ID matches on from accountList
                            accountList[i].Password = CaesarCipher.encrypt(inPass, PASS_KEY);            //update password for that ID

                            resultListBox.Items.Add("Password for (ID: " + inID + ") has been updated"); //let user know password was updated
                            break;                                                                       //exit; work is done
                        }
                    }
                } else {                                       //password didnt pass reqs
                    passwordMessage();
                }
            } else {                                           //ID was not found
                resultListBox.Items.Add("Sorry, ID " + inID + " wasn't found!");
                resultListBox.Items.Add(" ");
            }
        }

        /**********************************
         * passwordRedCheck(string )
         * returns: true, if the given password passes the reqs (8 chars, 1 uppercase, 1 lowercase, 1 digit)
         *          otherwise, false
         * arguments: a string, the given password to check
         * use: checks if the password given by the user passes the reqs
         ********************************/
        private bool passwordReqCheck(string inPass) {
            int upperCnt = 0,                         //counts
                lowerCnt = 0,
                digitCnt = 0,
                charCnt = 0;

            var charAR = inPass.ToCharArray();        //password string to char array

            for(int i = 0; i < charAR.Length; i++) {
                charCnt++;                           //plus one to total char count

                if (Char.IsLower(charAR[i])) {       //plus one to lower case count
                    lowerCnt++;
                }
                if (Char.IsUpper(charAR[i])) {       //plus one to upper case count
                    upperCnt++;
                }
                if (Char.IsDigit(charAR[i])) {      //plus one to digit count
                    digitCnt++;
                }
            }

            if((upperCnt != 0) &&                   //password has passed reqs
                (lowerCnt != 0) &&
                (digitCnt != 0) &&
                (charCnt > 7)) {
                return true;
            } else {                               //password has failed
                return false;
            }
        }

        /*************************************
         * Use: When the Delete Data button is clicked,
         *      ID/Password is checked, if a match is found, it's deleted from the accountList
         *************************************/ 
        private void deleteDataButton_Click(object sender, EventArgs e) {
            string inID = IDDeleteDataTextBox.Text;                //bring in ID text box data
            string inPass = confirmPasswordDeleteDataTextBox.Text; //bring in password text box data

            if (deleteDataWork(inPass, inID)) {                    //matching user entered ID/Password was found in accountList
                var itemToRemove = accountList.Single(account => account.IdNumber == inID);  //remove account from accountList
                accountList.Remove(itemToRemove);
                resultListBox.Items.Add("Item (ID: " + inID + ") was removed!");            //display message was removed
                resultListBox.Items.Add(" ");                                               //new line
            }
            else {                                                 //matching ID/Password was not found
                resultListBox.Items.Add("Sorry, incorrect ID or password!");
                resultListBox.Items.Add(" ");                                               //new line
            }
        }

        /***************************************
         * deleteDataWork(string, string )
         * returns: true, if a user entered a ID and password that match an account ID/Password in accountList
         *          otherwise, returns false
         * arguments: a string called checkPassword, the user entered password to search for
         *          a string called CheckID, the user entered ID to search for
         * use: checks if the user entered a valid account ID/password
         ***************************************/ 
        private bool deleteDataWork(string checkPassword, string checkID) {
            checkPassword = CaesarCipher.encrypt(checkPassword, PASS_KEY);   //encrypt user entered password to search
            
            foreach (var account in accountList) {                           //cycle thru accountList
                if (checkID.Equals(account.IdNumber)) {                      //found matching ID
                    if(checkPassword.Equals(account.Password)) {             //found matching password
                        return true;
                    }
                }
            }
            return false;                                                   //matching password not found
        }

        /*******************************************
        * Exits program when clicked, saves any changes made
        *******************************************/
        private void exitButton_Click(object sender, EventArgs e) {
            writeToFile();
            Application.Exit();
        }

        /********************************************
         * writeToFile()
         * returns: nothing
         * arguments: none
         * use: updates the file (totallySafeWayToKeepPasswords.txt), 
         *      to reflect any changes made to the passwords
         ********************************************/
        private void writeToFile() {
            string inLine;            //string to hold data from accountList

            try {
                StreamWriter outFile = new StreamWriter("totallySafeWayToKeepPasswords.txt");    //open txt file that holds site info

                foreach(var account in accountList) {                                            //cycle thru accountList
                    inLine = account.IdNumber + " " + account.SiteName + " " + account.Password; //put all account info into one string w/ spaces

                    outFile.WriteLine(inLine);                                                   //write the line to the txt file
                }
                outFile.Close();                                                                 //close file
            }
            catch (Exception e) {                                                                //couldnt find file
                Console.WriteLine("Couldn't find totallySafeWayToKeepPasswords.txt! Data not saved!");
            }
        }

        private void searchDataButton_Click(object sender, EventArgs e) {
            string inSite = siteNameSearchDataTextBox.Text;         //bring in site name text box

            var tupleRes = searchDataWork(inSite);                 //store tuple response

            if (tupleRes.Item1) {
                resultListBox.Items.Add(accountList[tupleRes.Item2].IdNumber.PadRight(3)  //print account info
                    + (accountList[tupleRes.Item2].SiteName.PadRight(10))
                    + (accountList[tupleRes.Item2].Password));
                resultListBox.Items.Add(" ");
            } else {                                                //site name not found
                resultListBox.Items.Add("Sorry, couldn't find that site!");
                resultListBox.Items.Add(" ");              
            }
        }

        /****************************************
         * searchDataWork(string )
         * arguments: a string, the site to search for
         * returns: tuple: true, if the site user entered if found in the accountList + index of the site name in the account list
         *          tuple: otherwise, returns false + a negative number
         * use: searches the accountList for a matching site name
         ****************************************/ 
        private Tuple<bool, int> searchDataWork(string searchSite) {
            for(int i = 0; i < accountList.Count; i++) {                        //cycle thru accountList
                if (String.Equals(accountList[i].SiteName, searchSite, StringComparison.OrdinalIgnoreCase)) {
                    return (new Tuple<bool, int>(true, i));                    //matching site found
                }
            }
            return (new Tuple<bool, int>(false, -9999));                            //no matching site found
        }

        /*****************************************
         * searchForID(bool )
         * arguments: a string called searchID, the ID to search for
         * returns: true if ID is found, otherwise returns false
         * use: searches the accountList for the desired ID
         ****************************************/
        private bool searchForID(string searchID) {
            foreach(var account in accountList) {        //cycle thru accountList
                if(searchID.Equals(account.IdNumber)) {  //found matching ID
                    return true;
                }
            }
            return false;                                //no matching ID found
        }

        /*******************************************
        * Prints out site name accountList
        *******************************************/
        private void viewDataButton_Click(object sender, EventArgs e) {
            foreach (var account in accountList) {                        //cycle thru list
                resultListBox.Items.Add(account.SiteName);               //print site
            }
            resultListBox.Items.Add(" ");
        }

        /**************************************************
         * stringTrim(string[])
         * Use: trims the ends of the strings in the array
         * ***********************************************/
        private void stringTrim(string[] stringT) {
            foreach (var trimString in stringT)
                trimString.Trim();
        }

        /***************************************************
         * When button is clicked will start a timer for 10 seconds,
         * sets passwords in listBox to be visible
         * *************************************************/ 
        private void viewPasswordButton_Click(object sender, EventArgs e) {
            resultListBox.Items.Clear();

            myTimer.Interval = 10000;                              //for 10 second
            myTimer.Start();                                       //start timer

            string inSite = siteNameSearchDataTextBox.Text;        //bring in site name
            var tupleRes = searchDataWork(inSite);                 //store if site was found + index location

            if (tupleRes.Item1) {                                  //site was found, print info
                resultListBox.Items.Add(accountList[tupleRes.Item2].IdNumber.PadRight(3)        //print account info
                    + (accountList[tupleRes.Item2].SiteName.PadRight(10))
                    + (CaesarCipher.decrypt(accountList[tupleRes.Item2].Password, PASS_KEY)));  //show password
            }
        }

        /***************************************************
         * Once the 10 seconds are up of the timer, passwords in listBox will be hidden again. 
         * stops timer
         * *************************************************/
        private void myTimerTick(object sender, EventArgs e) {
            resultListBox.Items.Clear();

            string inSite = siteNameSearchDataTextBox.Text;        //bring in site name
            var tupleRes = searchDataWork(inSite);                 //store if site was found + index location

            if (tupleRes.Item1) {                                  //site was found, print info
                resultListBox.Items.Add(accountList[tupleRes.Item2].IdNumber.PadRight(3)        //print account info
                    + (accountList[tupleRes.Item2].SiteName.PadRight(10))
                    + (accountList[tupleRes.Item2].Password));    //hide password
            }

            myTimer.Stop();                                       //stop timer
        }

        /***************************************
         * clearListBox_()
         * arguments: none
         * returns: nothing
         * use: clears list box
         **************************************/
        private void clearListBox_() {
            resultListBox.Items.Clear();
        }

        /***************************************
         * calls clearListBox() to clear list box
         **************************************/
        private void clearListBox_Click(object sender, EventArgs e) {
            clearListBox_();
        }
    }
}