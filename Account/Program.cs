using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("A",100);
            Account a1 = new Account("B", 200);
            a.transfer(a1,50);
            a.show();
            a1.show();

        }
    }
}
