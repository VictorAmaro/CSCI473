/***********************************************************
CSCI 473 - Assignment 5 - Spring 2018

Progammer: Victor Amaro
Z-ID: z1747708
Section: 2
Date Due: April 16, 2018

Purpose: Responsible for encrypting/decrypting data
************************************************************/
namespace Hw5 {
    class CaesarCipher {
        /***********************************
        * cipher(char, int )
        * arguments: 1) a char, called inputChar, the char to shift
        *           2) a int, called input key, decide how much to shift char by
        * returns: a char, the new char after encryption
        * use: gets called, and changes one char to another one 
        *   based on a speific condition
        ************************************/ 
        public static char cipher(char inputChar, int inputKey) {
            if (!char.IsLetter(inputChar)) {                                      //if not a char, leave alone
                return inputChar;
            }

            char newChar = char.IsUpper(inputChar) ? 'A' : 'a';                  //found out if uppercase
            return (char)((((inputChar + inputKey) - newChar) % 26) + newChar);  //return new char, under certain condition
        }

        /***********************************
        * encrypt(string, int )
        * arguments: 1) a string called, inputPassword, the password to enecrypt
        *           2) a int, called input key, decide how much to shift char by
        * returns: a string, the newly encrypted password
        * use: gets called, and returns a new encrypted password
        ************************************/
        public static string encrypt(string inputPassword, int inputKey) {
            string encryptedPassword = string.Empty;                            //will hold new password

            foreach (char ch in inputPassword) {                                //cycles thru every char in password string
                encryptedPassword += cipher(ch, inputKey);                      //calls cipher to change the char
            }

            return encryptedPassword;                                           //returns new constructed password
        }

        /***********************************
        *decryptt(string, int )
        * arguments: 1) a string called, inputPassword, the password to decrypt
        *           2) a int, called input key, decide how much to shift char by
        * returns: a string, the decrypted password
        * use: gets called, and calls encrypt() to reverse its process
        ************************************/
        public static string decrypt(string inputPassword, int inputKey) { 
            return encrypt(inputPassword, (26 - inputKey));                   //reverse work done by encrypt
        }
    }
}