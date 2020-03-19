/***********************************************************
CSCI 473 - Assignment 1 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: Feb 02, 2018

Purpose: practice using some features of C# which are 
    different from C++ and also to practice using the Visual Studio IDE.
************************************************************/

using System;
using System.IO;

namespace Assign1 {
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
        public static class Program {
            public static int totalSpace = 20;                         //Array will hold this many spots
            public static Person[] personAR = new Person[totalSpace];  //array the will hold up to 20 Person objects
            public static int personCount = 0;                         //counter for how many objects are in the Person array

            /******************************
            * void printMenu()
            * Prints out the menu choices
            ******************************/
            public static void printMenu() {
                Console.WriteLine("Please select an option! \n" +
                    "a. Print the list \n" +
                    "b. Add an entry \n" +
                    "c. Search for a name \n" +
                    "d. Search for a office number \n" +
                    "e. Search for a telephone number \n" +
                    "f. Change an office number \n" +
                    "g. Sort the list (by name) \n" +
                    "h. Quit \n");
            }

            /******************************
            * void printList(Person[], int)
            * Arg 1: an array of Person objects
            *   Arg 2: an int that keeps track of how many spots in array are in use
            * Cycles through Person array and prints the name, office number, and telephone number
            ******************************/
            public static void printList() {
                Console.WriteLine("Printing List....");

                for (int i = 0; i < personCount; i++) {
                    printSpecificArrayLoc(i);
                }
                Console.WriteLine();
            }

            /******************************
            * void addEntrey()
            * Asks the user to enter name, office number, and telephone number
            *   if name already present, exits and prints message saying name is already present
            *       if not, adds the new entry to the person array
            ******************************/
            public static void addEntry() {
                Console.WriteLine("Please enter a name: ");   //Get user name
                String newName = Console.ReadLine();

                for (int i = 0; i < personCount; i++) {       //cycle through array to look for name
                    if (newName.Equals(personAR[i].PersonName, StringComparison.CurrentCultureIgnoreCase)) {  //already present name, exit
                        Console.WriteLine("That name is already present! \n");
                        return;
                    }
                }

                Console.WriteLine("Please enter a office number: ");     //get office number
                String newOfficeNum = Console.ReadLine();

                Console.WriteLine("Please enter a telephone number: ");  //get telephone number
                String newTeleNum = Console.ReadLine();

                personAR[personCount] = new Person(newName, newOfficeNum, newTeleNum);  //add entry to array person
                personCount++;   //add one to total count of entries in array

                Console.WriteLine("\nEntry added, done. \n");
            }

            /******************************
            * void printSpecificArrayLoc( int )
            * Arg 1: int, which is location in array to print
            * Gets the location from Arg 1 then prints all info for that array location
            ******************************/
            public static void printSpecificArrayLoc(int loc) {
                Console.WriteLine((personAR[loc].PersonName.PadRight(12)) +
                    (personAR[loc].PersonOfficeNum.PadRight(8)) +
                    (personAR[loc].PersonTeleNum));
            }

            /******************************
            * void searchOfficeNum( )
            * asks user what office number to search for
            * cycles through person array to look for office number
            *   if match is found, prints out person info
            *   if no match is found, prints out message saying to
            ******************************/
            public static void searchOfficeNum() {
                Console.WriteLine("Please enter the office number you would like to search for: ");   //asks user to enter the office number to search for
                String searchOffice = Console.ReadLine();
                Console.WriteLine();

                bool found = false;  // results were found?

                for (int i = 0; i < personCount; i++) {       //cycle through array to look for office number
                    if (searchOffice.Equals(personAR[i].PersonOfficeNum, StringComparison.CurrentCultureIgnoreCase)) {  //was office number found?
                        found = true;
                        printSpecificArrayLoc(i);
                    }
                }

                Console.WriteLine();

                if (found == false) {    //no matches
                    Console.WriteLine("No matching office numbers for {0} were found!\n", searchOffice);
                }
            }

            /******************************
            * void searchTeleNum( )
            * asks user what telephone number to search for
            * cycles through person array to look for telephone number
            *   if match is found, prints out person info
            *   if no match is found, prints out message saying to
            ******************************/
            public static void searchTeleNum() {
                Console.WriteLine("Please enter the telephone number you would like to search for: ");   //asks user to enter the telephone number to search for
                String searchTele = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < personCount; i++) {       //cycle through array to look for telephone number
                    if (searchTele.Equals(personAR[i].PersonTeleNum, StringComparison.CurrentCultureIgnoreCase)) {  //was telephone number found?
                        printSpecificArrayLoc(i);    //Print person info
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine("No matching telephone numbers for {0} were found!\n", searchTele);
            }

            /******************************
            * void changeOfficeNum( )
            * asks the user to enter the name of the person's office to change
            * looks for that person
            *   if found, asks for the new office number and changes it
            *   if not found, displays a message saying so
            ******************************/
            public static void changeOfficeNum() {
                Console.WriteLine("Please enter the name of the person of who's office number you want to change: ");   //asks user to enter the name of person to change office number
                String searchName = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < personCount; i++) {       //cycle through array to look for person
                    if (searchName.Equals(personAR[i].PersonName, StringComparison.CurrentCultureIgnoreCase)) {  //person found
                        Console.WriteLine("Enter the new office number: ");   //asks user to enter the name of person to change office number
                        String newOffice = Console.ReadLine();
                        Console.WriteLine();

                        personAR[i].PersonOfficeNum = newOffice;             //changes office number for the person 

                        Console.WriteLine("Done, {0}'s office number has been changed to {1}\n", searchName, newOffice);
                        return;
                    }
                }
                Console.WriteLine("\nPerson, {0}, not found!\n", searchName);   //Person wasnt found
            }

            /******************************
            * void changeOfficeNum( )
            * asks the user to enter the name of the person's office to change
            * looks for that person
            *   if found, displays person
            *   if not found, displays a message saying so
            ******************************/
            public static void searchByName() {
                Console.WriteLine("Please enter the name you would like to search for: ");   //asks user to enter the office number to search for
                String searchName = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < personCount; i++) {       //cycle through array to look for name
                    if (searchName.Equals(personAR[i].PersonName, StringComparison.CurrentCultureIgnoreCase)) {  //was name found?
                        printSpecificArrayLoc(i);            //Print name
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine("No matching name for {0} were found!\n", searchName);    //Name wasnt found
            }

            public static void Main() {
                String userChoice;     //char to hold user choice in menu
                String currentLine;    //Will hold a line from file to bring in

                StreamReader inFile = new StreamReader("data1.txt");  //Bring in file

                for (int i = 0; i < totalSpace; i++) {                           //set defaults
                    personAR[i] = new Person("null", "null", "null");
                }

                currentLine = inFile.ReadLine(); //get first line
                while (currentLine != null) {
                    personAR[personCount].PersonName = currentLine;         //Set the name
                    currentLine = inFile.ReadLine();                        //get next line

                    personAR[personCount].PersonOfficeNum = currentLine;    //Set the office number
                    currentLine = inFile.ReadLine();                        //get next line

                    personAR[personCount].PersonTeleNum = currentLine;      //Set the telephone
                    currentLine = inFile.ReadLine();                        //get next line

                    personCount++;                                          //a person was added, add one to count
                }

                inFile.Close();  //close file

                printMenu();
                userChoice = Console.ReadLine();                      //get user choice

                while (userChoice.ToLower() != "h") {     //while user hasnt selected quit option
                    switch (userChoice) {
                        case "a":            //User picked to print out entire list
                            Console.WriteLine();
                            printList();
                            break;
                        case "b":           //user picked to add an entry
                            Console.WriteLine();
                            addEntry();
                            break;
                        case "c":          //user picked to search by name   
                            Console.WriteLine();
                            searchByName();
                            break;
                        case "d":          //user picked to search by office number
                            Console.WriteLine();
                            searchOfficeNum();
                            break;
                        case "e":          //user picked to search by telephone number
                            Console.WriteLine();
                            searchTeleNum();
                            break;
                        case "f":         //user picked to change office number
                            Console.WriteLine();
                            changeOfficeNum();
                            break;
                        case "g":         //user picked to sort array by name
                            Console.WriteLine();
                            Array.Sort(personAR, 0, personCount);          //sorts array starting at index 0, up to the last index used
                            Console.WriteLine("Done sorting.\n");
                            break;
                        default:         //User didnt enter valid choice
                            Console.WriteLine("That was not a valid choice!\n");
                            break;
                    }
                    printMenu();
                    userChoice = Console.ReadLine();                      //get user choice
                    userChoice = userChoice.ToLower();
                }
                Console.Write("Press enter to exit\n");
            }
        }
} 