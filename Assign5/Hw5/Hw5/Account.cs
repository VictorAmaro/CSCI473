/***********************************************************
CSCI 473 - Assignment 5 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: April 16, 2018

Purpose: Account class, to make objects of Accounts with data from text file
************************************************************/
using System;

namespace Hw5 {
    public class Account {
        private string idNumber;              //site's id number
        public string IdNumber {
            get { return idNumber; }
            set { idNumber = value; }
        }

        private String siteName;          //site's name
        public String SiteName {
            get { return siteName; }
            set { siteName = value; }
        }

        private String password;         //site's password
        public String Password {
            get { return password; }
            set { password = value; }
        }

        //Constructor
        public Account(string newID, String newSite, String newPass) {
            idNumber = newID;
            siteName = newSite;
            password = newPass;
        }
    }
}
