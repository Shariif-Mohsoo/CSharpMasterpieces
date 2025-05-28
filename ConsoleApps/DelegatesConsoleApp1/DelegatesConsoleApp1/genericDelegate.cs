using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp1
{
    //creating a generic delegate
    public delegate T add<T>(T n1,T n2);

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
    }
    class genericDelegate
    {
        public static void Main(string[] args)
        {
            add<int> sum = Numbers.Sum;
            Console.WriteLine(sum(10, 20));
            add<string> con = Numbers.Concat;
            Console.WriteLine(con("Hello", " World"));
        }


    }
}
