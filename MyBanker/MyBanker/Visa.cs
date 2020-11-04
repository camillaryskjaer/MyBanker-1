using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Visa : Card
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public Visa(string name) : base(name)
        {
            Cardname = "Visa";
            AccountNumber = AccountNumberGen();
            CardNumber = CardNumberGen(4);
            Expirydate = ExpiryDateGen(4);
        }
    }
}
