using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Maestro : Card, IWithDraw
    {
        public List<int> Prefix { get; set; }
        public int MaestroGen()
        {
            Prefix = new List<int> { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            Random rand = new Random();
            int index = rand.Next(Prefix.Count);
            int startnumber = Prefix[index];
            return startnumber;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public Maestro(string name) : base(name)
        {
            Cardname = "Maestro";
            AccountNumber = AccountNumberGen();
            CardNumber = CardNumberGen(MaestroGen());
            Expirydate = ExpiryDateGen(MaestroGen());
        }
    }
}
