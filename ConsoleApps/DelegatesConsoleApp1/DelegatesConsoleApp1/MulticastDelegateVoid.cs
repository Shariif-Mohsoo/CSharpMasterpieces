using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp1
{
    // Step 1: Create a delegate
    public delegate void ShowMessage();
    class MulticastDelegateVoid
    {
        // Step 2: Create some methods
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome");
        }

        public static void Bye()
        {
            Console.WriteLine("Goodbye");
        }

        class Program
        {
            public static void Main()
            {
                // Step 3: Create delegate and add methods
                //okay //ShowMessage msg = new ShowMessage(Hello);
                ShowMessage msg = Hello;
                //logical error ; output starts from here..
                //msg = new ShowMessage(Welcome);
                msg += Welcome;
                msg += Bye;

                // Step 4: Call the delegate
                msg();  // All 3 methods will run
                        //output
                        //            Hello
                        //            Welcome
                        //            Goodbye

            }
        }
    }

}

