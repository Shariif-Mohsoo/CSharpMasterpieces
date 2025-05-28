using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp1
{
    //delclaring a generic delegate
    public delegate T add<T>(T n1,T n2);
    // Generic delegate with two parameters of different types and no return
    public delegate void print<T1, T2>(T1 param1, T2 param2);



    class Numbers
    {
        //concept of overloading.
        public static int Sum(int n1,int n2)
        {
            return n1 + n2;
        }
        public static string Concat(string s1,string s2)
        {
            return s1 + s2;
        }

        public static void sayHi<T1,T2>(T1 str,T2 num)
        {
            Console.WriteLine(str + " Times: " + num);
            //Console.WriteLine($"val1: {str}, vals: {num}");
        }
    }
    class genericDelegate
    {
        public static void Main(string[] args)
        {
            add<int> sum = Numbers.Sum;
            Console.WriteLine(sum(10, 20));
            add<string> con = Numbers.Concat;
            Console.WriteLine(con("Hello", " World"));
            //2nd
            print<string, int> display = Numbers.sayHi;
            display("Hi",2);
        }


    }
}
