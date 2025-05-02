using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
✅ Task 2: Shape Area Calculator (Abstract, Override)
Goal: Create an abstract class Shape with an abstract method GetArea(). Create Circle, Rectangle, and Square classes that inherit from Shape and implement GetArea().

Keywords to practice: abstract, override, inheritance 
*/

namespace PracticeConsoleApp1
{
    public abstract class Shape
    {
        //we can create the variables in the abstract class.
        //public int x;
        
        public abstract void GetArea();
        //we can also create the simple functions in an abstarct class live demo is below
        public void Hello()
        {
            Console.WriteLine("HEllo");
        }
    }
    public class Circle:Shape
    {
        public float r;
        public Circle(float r)
        {
            this.r = r;
        }
        public override void GetArea()
        {
            Console.WriteLine("Circle Area: " + Math.PI * Math.Pow(r,2));
            // THE BELOW WRITTEN LINE IN NOT APPROPRIATE; IT'S A LOGICAL ERROR.
            // Console.WriteLine("Circle Area: " , Math.PI * Math.Pow(r,2));
        }
    }
    
}
