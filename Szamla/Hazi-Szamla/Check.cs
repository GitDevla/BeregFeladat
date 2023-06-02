using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_Szamla
{
    internal class Check
    {
        readonly int id;
        readonly string name;
        readonly int balance;
        readonly DateTime date;

        public Check(int id, string name, int balance, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.date = date;
        }

        public int Id => id;
        public string Name => name;
        public int Balance => balance;
        public DateTime Date => date;

        public override string ToString()
        {
            return name;
        }
    }
}
