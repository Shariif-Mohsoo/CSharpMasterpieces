using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp1
{
    public delegate int GetNumber();
    class MulticastDelegateReturn
    {
        public static int First()
        {
            return 1;
        }

        public static int Second()
        {
            return 2;
        }

        //public static void Main()
        //{
        //    //wrong will show/cause an error.
        //    //GetNumber num = new GetNumber(first, second);
        //    GetNumber num = First;
        //    num += Second;
        //    int result = num();  // Only returns from Second
        //    Console.WriteLine(result);  // Output: 2
        //}

    }
}
