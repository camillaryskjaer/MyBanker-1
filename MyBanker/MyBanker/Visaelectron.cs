using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Visaelectron : Card,IWithDraw
    {

        public List<int> Prefix { get; set; }
        public int VisaElectronGen()
        {
            Prefix = new List<int> { 4026, 417500, 4508, 4844, 4913, 4917 };
            Random rand = new Random();
            int index = rand.Next(Prefix.Count);
            int startnumber = Prefix[index];
            return startnumber;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public Visaelectron(string name) : base(name)
        {
            Cardname = "Visa Electron";
            AccountNumber = AccountNumberGen();
            CardNumber = CardNumberGen(VisaElectronGen());
            Expirydate = ExpiryDateGen(VisaElectronGen());
        }
    }
}
