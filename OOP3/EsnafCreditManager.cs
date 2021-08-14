using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class EsnafCreditManager : ICreditManager
    {
        void ICreditManager.Calculate()
        {
            Console.WriteLine("esnafcredit");
        }

        void ICreditManager.DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
