using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyBanker
{
    class Menu
    {
        public void start()
        {

            while (true)
            {
                try
                {
                    Information();
                    Console.WriteLine("Enter to return to start");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Something went wrong try again");
                    Information();
                } 
            }
        }
        public void Information() //Promting the user with a menu to insert name and age
        {
            Console.WriteLine("Bank Register");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            DebitCard debit = new DebitCard(name);
            Maestro maestro = new Maestro(name);
            Mastercard mastercard = new Mastercard(name);
            Visaelectron visaelectron = new Visaelectron(name);
            Visa visa = new Visa(name);

            if (age <= 18)//Only showing cards that are relevant for the users age
            {
                Cardform(debit);
            }
            if (age >= 18)
            {
                Cardform(visa);
                Cardform(maestro);
            }
            if (age >= 15)
            {
                Cardform(visaelectron);
            }
            Cardform(mastercard);
        }

        public void Cardform(Card card)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(card.Cardname);
            Console.WriteLine("Owner: " + card.Name);
            Console.WriteLine("AccountNumber: " + card.AccountNumber);
            Console.WriteLine("Cardnumber: " + card.CardNumber);
            Console.WriteLine("Expiry date: " + card.Expirydate);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
