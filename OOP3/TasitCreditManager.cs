using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
