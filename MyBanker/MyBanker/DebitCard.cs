using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyBanker
{
    class  DebitCard : Card
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public DebitCard(string name) : base(name)
        {
            Cardname = "Debit Card";
            AccountNumber = AccountNumberGen();
            CardNumber = CardNumberGen(2400);
            Expirydate = ExpiryDateGen(2400);
        }
    }
    
}
