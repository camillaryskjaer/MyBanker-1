using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Mastercard : Card,IWithDraw
    {
        public List<int> Prefix { get; set; }
        
        //Denne metode kunne du godt gøre langt mere generel, så du ikke skal implementere denne for hver korttype
        public int MasterCardGen()
        {
            Prefix = new List<int> { 51, 52, 53, 54, 55 };
            Random rand = new Random();
            int index = rand.Next(Prefix.Count);
            int startnumber = Prefix[index];
            return startnumber;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public Mastercard(string name) : base(name)
        {
            Cardname = "Mastercard";
            AccountNumber = AccountNumberGen();
            CardNumber = CardNumberGen(MasterCardGen());
            Expirydate = ExpiryDateGen(MasterCardGen());
        }
    }
}
