/***********************************************************
CSCI 473 - Assignment 2 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: Feb 16, 2018

Purpose: redo assignemnt 1, but using a form.
    practice with Lists, Radio Buttons, TextBoxes, ListBoxes
************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assign2 {
    public partial class Form1 : Form {
        public static List<Person> personList = new List<Person>();   //Create list of Person 

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadList();    //When application is started up, load the list with Person objects
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) {
            
            if (printListButton.Checked) {              //user selected to view entire list
                resultBox.Items.Clear();
                printList();
                printListButton.Checked = false; 
            }
            if(addEntryButton.Checked) {               //user selected to add an entry to the list
                resultBox.Items.Clear();
                addEntry();
                addEntryButton.Checked = false;
            }
            if(nameSearchButton.Checked) {            //user selected to search by name
                resultBox.Items.Clear();
                searchByName();
                nameSearchButton.Checked = false;
            }
            if (officeSearchButton.Checked) {         //user selected to search by office number
                resultBox.Items.Clear();
                searchByOffice();
                officeSearchButton.Checked = false;
            }
            if(teleSearchButton.Checked) {            //user selected to search by telephone number 
                resultBox.Items.Clear();
                searchByTele();
                teleSearchButton.Checked = false;
            }
            if(changeOfficeButton.Checked) {          //user selected to change an office number
                resultBox.Items.Clear();
                changeOffice();
                changeOfficeButton.Checked = false;
            } 
            if(sortButton.Checked) {                 //user selected to sort list
                resultBox.Items.Clear();
                personList.Sort();
                resultBox.Items.Add("Done Sorting.");
                sortButton.Checked = false;
            }
            if (clearButton.Checked) {                //user selected to clear all fields
                clearAll();
            }
            if (exitButton.Checked) {                //user selected to exit program
                Application.Exit();
            }   
        }

        /***************************************************
         * searchByName()
         * returns: nothing
         * arguments: none
         * use: if nameTextBox is left empty, displays message, returns  
         *  grabs contents of nameTextBox and begins to search for the person
         *  if found displays message saying so
         *  if not found displays message
         *  ************************************************/
        private void searchByName() {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text)) {
                resultBox.Items.Add("No blank in the text field is allowed!");    //checks if empty strings were entered
                return;
            }

            string searchName = nameTextBox.Text;    //grab text box contents
            bool found = false;

            foreach(var temp in personList) {       //cycle thru person list
                if(temp.PersonName.Equals(searchName, StringComparison.CurrentCultureIgnoreCase)) {   //compare given name
                    found = true;

                    resultBox.Items.Add((temp.PersonName.PadRight(11)) +                              //person was found, display their info
                    (temp.PersonOfficeNum.PadRight(7)) +
                    (temp.PersonTeleNum));
                }
            }

            if(!found) {                                                                            //person wasn't found, display message
                resultBox.Items.Add("No matching name for " + searchName + " was found!");
            }
        }

        /***************************************************
        * changeOffice()
        * returns: nothing
        * arguments: none
        * use: **Enter the person's name of officw you wish to change, along with the NEW office number**
        *  if nameTextBox is left empty, displays message, returns 
        *  grabs nameTextBox contents and begins to search for the perosn to change office number
        *  if found, will ask user to enter new office number and do the checking before updating office number
        *  if not found will display message saying so
        *  ************************************************/
        private void changeOffice() {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(officeTextBox.Text)) {
                resultBox.Items.Add("No blank in the text field is allowed!");    //checks if empty strings were entered
                return;
            }

            string searchName = nameTextBox.Text;    //grab name text box contents

            foreach (var temp in personList) {
                if (temp.PersonName.Equals(searchName, StringComparison.CurrentCultureIgnoreCase)) {   //compare given name

                    string newOffice = officeTextBox.Text;                               //grab office textbox contents
                    temp.PersonOfficeNum = newOffice;

                    resultBox.Items.Add("Done, " + searchName + "'s office number was changed to " + newOffice);

                    return;
                }
            }

            resultBox.Items.Add("Person " + searchName + " was not found!");          //person wasnt found
        }

        /***************************************************
        * searchByOffice()
        * returns: nothing
        * arguments: none
        * use: Checks if a empty string was entered into telephone text box, if yes, displays messages, returns 
        *  Grabs the office number entered in nameTextBox and searches for it,  
        *  if no office was found displays a message
        *  ************************************************/
        private void searchByOffice() {
            if (string.IsNullOrWhiteSpace(officeTextBox.Text)) {
                resultBox.Items.Add("No blank in the text field is allowed!");    //checks if empty strings were entered
                return;
            }

            string searchOffice = officeTextBox.Text;    //grab text box contents
            bool found = false;

            foreach (var temp in personList) {           //cycle thru person list
                if (temp.PersonOfficeNum.Equals(searchOffice)) {   //compare given office number
                    found = true;

                    resultBox.Items.Add((temp.PersonName.PadRight(11)) +                              //person was found, display their info
                    (temp.PersonOfficeNum.PadRight(7)) +
                    (temp.PersonTeleNum));
                }
            }

            if (!found) {                                                                            //person wasn't found, display message
                resultBox.Items.Add("No matching office for " + searchOffice + " was found!");
            }
        }

        /***************************************************
        * searchByTele()
        * returns: nothing
        * arguments: none
        * use: Checks if a empty string was entered into telephone text box, if yes, displays messages, returns 
        *  Grabs the telephone number entered in nameTextBox and searches for it,  
        *  if no telephone number was found displays a message
        *  ************************************************/
        private void searchByTele() {
            if (string.IsNullOrWhiteSpace(telephoneTextBox.Text)) {
                resultBox.Items.Add("No blank in the text field is allowed!");    //checks if empty strings were entered
                return;
            }

            string searchTele = telephoneTextBox.Text;    //grab text box contents
            bool found = false;

            foreach (var temp in personList) {           //cycle thru person list
                if (temp.PersonTeleNum.Equals(searchTele)) {   //compare given telephone number
                    found = true;

                    resultBox.Items.Add((temp.PersonName.PadRight(11)) +                              //person was found, display their info
                    (temp.PersonOfficeNum.PadRight(7)) +
                    (temp.PersonTeleNum));
                }
            }

            if (!found) {                                                                            //person wasn't found, display message
                resultBox.Items.Add("No matching telephone for " + searchTele + " was found!");
            }
        }

        /***************************************************
         * addEntry()
         * returns: nothing
         * arguments: none
         * use: Checks if any empty string were entered in the textboxes, if yes displays message and returns, 
         *  sets string vars to textbox contents,
         *  then checks if the name is already present, if yes diaplys message and returns,
         *  adds the new entry to the person list, displays message
         **************************************************/
        private void addEntry() {
            if ( (string.IsNullOrWhiteSpace(nameTextBox.Text)) || (string.IsNullOrWhiteSpace(officeTextBox.Text)) || (string.IsNullOrWhiteSpace(telephoneTextBox.Text)) ) {
                resultBox.Items.Add("No blanks in the text fields are allowed!");    //checks if empty strings were entered
                return;
            }

            string newName = nameTextBox.Text;
            string newOffice = officeTextBox.Text;
            string newTele = telephoneTextBox.Text;

            foreach (var temp in personList) {
                if(temp.PersonName.Equals(newName, StringComparison.CurrentCultureIgnoreCase)) {    //checks if name is already present
                    resultBox.Items.Add("That name is already present!");
                    return;
                }
            }

            personList.Add(new Person(newName, newOffice, newTele));               //adds new entry
            resultBox.Items.Add("Entry added, done!");
        }


        /***************************************************
         * printList()
         * returns: nothing
         * arguments: none
         * use: Add every item in the person list to the resultBox (a list box),
         *  will display -> Person Name : Person Office Number : Person Telephone Number
         **************************************************/
        private void printList() {
            foreach (var charac in personList) {
                resultBox.Items.Add((charac.PersonName.PadRight(11)) +
                    (charac.PersonOfficeNum.PadRight(7)) +
                    (charac.PersonTeleNum));
            }
        }

        /***************************************************
         * clearAll()
         * returns: nothing
         * arguments: none
         * use: clears out the listbox and the text boxes 
         **************************************************/
        private void clearAll() {
            nameTextBox.Clear();
            officeTextBox.Clear();
            telephoneTextBox.Clear();

            resultBox.Items.Clear();
        }

        /***************************************************
         * loadList()
         * returns: nothing
         * arguments: none
         * use: Opens the text file to be read,
         *  reads the lines, storing them as a string,
         *  adds a new Person object to the person list using the strings for the constructor argument,
         *  closes file
         **************************************************/
        private void loadList() {
            String currentLine,
                personName,
                personOffice,
                personTele;

            StreamReader inFile = new StreamReader("data1.txt");  //Bring in file

            currentLine = inFile.ReadLine();                             //get first line
            while (currentLine != null) {
                personName = currentLine;                                //store name

                currentLine = inFile.ReadLine();                        //get next line
                personOffice = currentLine;                              //store office number

                currentLine = inFile.ReadLine();                        //get next line
                personTele = currentLine;                               //store tele number

                personList.Add(new Person(personName, personOffice, personTele));  //add to list

                currentLine = inFile.ReadLine();                        //get next line
            }
            inFile.Close();                                            //close file
        }
    }

    public class Person : IComparable {
        private String personName;           //private data member to hold name as string  
        public String PersonName {           //public properties Get and Set
            get { return personName; }
            set { personName = value; }
        }

        private String personOfficeNum;     //private data member to hold persons office number as a string
        public String PersonOfficeNum {     //public properties Get and Set
            get { return personOfficeNum; }
            set { personOfficeNum = value; }
        }

        private String personTeleNum;       //private data member to hold persons office number as a string
        public String PersonTeleNum {       //public properties Get and Set
            get { return personTeleNum; }
            set { personTeleNum = value; }
        }

        public Person(String newPersonName, String newPersonOfficeNum, String newPersonTeleNum) {  //constructor to initialize String values
            personName = newPersonName;
            personOfficeNum = newPersonOfficeNum;
            personTeleNum = newPersonTeleNum;
        }

        public int CompareTo(object OBJ) {      //Takes a Person as an Object, then uses it to compare the person's name     
            Person temp = OBJ as Person;

            return String.Compare(this.PersonName, temp.PersonName);
        }

    }
}
