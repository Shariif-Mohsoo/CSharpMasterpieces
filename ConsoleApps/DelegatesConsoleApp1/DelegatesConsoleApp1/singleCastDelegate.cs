using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp1
{
    //creating a delegate
    public delegate int MathOperation();
    class singleCastDelegate
    {
        private int x;
        private int y;
        public singleCastDelegate() {
            x = 0;
            y = 0;
        }
        public singleCastDelegate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int AddNumbers()
        {
            return x + y;
        }
    }
    class Test
    {
        //public static void Main()
        //{
        //    //creating a class instance
        //    singleCastDelegate obj1 = new singleCastDelegate(1,9);
        //    MathOperation MO = new MathOperation(obj1.AddNumbers);
        //   //invoking the delegate
        //    Console.WriteLine(MO());
        //    singleCastDelegate obj2 = new singleCastDelegate(0,9);
        //    MO = new MathOperation(obj2.AddNumbers);
        //    Console.WriteLine(MO());
        //}
    }
}
