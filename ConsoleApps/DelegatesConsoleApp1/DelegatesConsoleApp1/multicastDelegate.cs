using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a program that:
1. Defines a delegate called MathOperations that takes two integers and returns an integer.
2. Implements two methods: Add(int a, int b) and Multiply(int a, int b).
3. Uses the delegate to call both methods and print the results.

✍️ Your Task:
Define the delegate.
Write both methods.
Assign the methods to the delegate and invoke them.
Print the results.
 */
namespace DelegatesConsoleApp1
{
    public delegate int MathOperations(int x, int y);
    class multicastDelegate
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a,int b)
        {
            return a * b;
        }
    }

    class program
    {
        public static int sub(int a,int b)
        { return a - b; }
        public static int div(int a,int b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
        //public static void Main()
        //{
        //    multicaseDelegate obj = new multicaseDelegate();
        //    MathOperations opt = new MathOperations(obj.add);
        //    opt += obj.Multiply;
        //    Console.WriteLine(opt(1, 2));
        //    // the below written line code will only in the case of void return type.
        //    // opt = sub + div;
        //    opt = new MathOperations(sub);
        //    opt += div;
        //    Console.WriteLine(opt(4,2));
        //}
    }

}
