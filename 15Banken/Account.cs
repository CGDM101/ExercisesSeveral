using System;
using System.Collections.Generic;
using System.Text;

namespace _15Banken
{
    public class Account
    {
        public double Cash { get; set; } = 0;
        public string Name { get; set; } = "";
        public string AccountNr { get; set; } = "";
        public virtual void WithDraw(double amount) { }
        public virtual void Deposit(double amount) { }

    }
}
