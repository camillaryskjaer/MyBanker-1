using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBanker
{
    public abstract class Card
    {
        private string cardname;

        public string Cardname
        {
            get { return cardname; }
            set { cardname = value; }
        }

        private string accountnumber;

        public string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }

        private string cardnumber;

        public string CardNumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }
        private string expirydate;

        public string Expirydate
        {
            get { return expirydate; }
            set { expirydate = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Card(string name)
        {
            Name = name;
        }

        private string RandomNumberGen(int startnumber,int numberofnumbers)
        {//Here we are making a method for handling the making of a random number. Now we can call this when we need a random generated number
            string result = $"{startnumber}";
            Random rand = new Random();
            for (int i = 0; i < numberofnumbers; i++)
            {
                result += rand.Next(9);
            }
            return result;
        }

        public string AccountNumberGen()
        {//here we create the account number by calling the random number method and giving it the parameters of the 4 first numbers and how long the random number needs to be.
           AccountNumber =  RandomNumberGen(3520,10);// this method basically just says mynumber + fill 10 more random on the end
            return AccountNumber;
        }
        
        //Her bryder du med SOLID og Dependency inversion..... Superklasser må ikke vide noget om deres subklasser!!!!
        public string CardNumberGen(int startnumber)
        {//Checks the value of start number as the different cards has special lenght's
            int value = 0;
            if(startnumber <= 417500&& startnumber >= 2400 )//visa electron & debitcard & Maestro
            {
              value = 12;
            }else 
            if (startnumber == 4)//visa
            {
                value = 15;
            }else
            if (startnumber > 50 && startnumber < 56)//mastercard
            {
                value = 14;
            }
            return RandomNumberGen(startnumber,value);
        }
        
        
            //Igen bryder du med SOLID og Dependency inversion..... Superklasser må ikke vide noget om deres subklasser!!!!
  
        public string ExpiryDateGen(int startnumber)
        {
            DateTime datebase = new DateTime();
            datebase = DateTime.Now;
            if (startnumber > 4025 && startnumber < 4918 || startnumber > 50 && startnumber < 56 || startnumber == 4)//visa electron & mastercard & visa
            {
                datebase = datebase.AddYears(5);
            }
            else
            if (startnumber > 5017 && startnumber < 6764)//Maestro
            {
                datebase = datebase.AddYears(5);//Adding years to the expire date
                datebase = datebase.AddMonths(8);
            }
            else
            if (startnumber == 2400)
            {
                return "never";
            }
            return datebase.ToShortDateString();
        }


    }
}
