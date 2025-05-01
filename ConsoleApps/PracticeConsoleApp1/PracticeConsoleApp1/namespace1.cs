using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
✅ Task 1: Animal Sounds (Inheritance, Virtual, Override)
Goal: Create a base class Animal with a virtual method MakeSound(). Inherit Dog, Cat, and Cow classes from it and override the method.

Keywords to practice: class, virtual, override, inheritance 
*/
namespace PracticeConsoleApp1
{
    public class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Ho Ho HO");
        }
    }
    public class Cow:Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Woooo Wooo Wooo");
        }
    }
    //same process will be for the Cat and Dog.
    class namespace1
    {
        static void Main(string[] args)
        {
            //namespace1
            //Cow c = new Cow();
            //c.makeSound();

            //namespace2
            //Circle c2 = new Circle((float)2.22);
            //c2.GetArea();
            //c2.Hello();

            //namespace3
            BankAccount ba = new BankAccount();
            ba.Menu();


            Console.ReadKey();
        }
    }
}
