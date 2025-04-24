//using System;
//using ClassLibrary;
//namespace firstProgram
//{
//    class myProgram
//    {
//        static int sum(int a,int b)
//        {
//            return a + b;
//        }
//        static int factorial(int num)
//        {
//            if (num == 0)
//                return 1;
//            return num * factorial(num - 1);
//        }

//        static bool isPrime(int num)
//        {
//            if (num == 2)
//                return true;
//            if (num <= 1)
//                return false;
//            for(int i = 2;i<=num;i++)
//            {
//                if (i == num)
//                    continue;
//                if (num % i == 0)
//                    return false;
//            }
//            return true;
//        }

//        static void typeCasting()
//        {
//            //here in this function we will see the type casting (converting one type to other)
//            //here the class we use for the purpose of the type casting is (Convert);
//            //to check the data type we use the function GetType().
//            double n = 22.22;
//            Console.WriteLine(n +" is of the type "+n.GetType());
//            int n2 = Convert.ToInt32(n);
//            Console.WriteLine(n2 + " is of the type " + n2.GetType());
//            const string name = "Mohsin";
//            Console.WriteLine("The name of the person who is playing with the type casting is " + name);
//            String test = "222";
//            int num = Convert.ToInt32(test);
//            Console.WriteLine("After converting the string '" + test + "' into the " + num.GetType()+ " we get "+num);
//            String first = "M";
//            Console.WriteLine("The " + first +" is of the type " + first.GetType());
//            char ch = Convert.ToChar(first);
//            Console.WriteLine("Now " + ch + " is of the type " + ch.GetType());
//            String isBoolean = "True";
//            Console.WriteLine("Dear " + isBoolean + " is of the type " + isBoolean.GetType());
//            bool isBooleanReally = Convert.ToBoolean(isBoolean);
//            Console.WriteLine("Now " + isBooleanReally + " is really of the type " + isBooleanReally.GetType());

//            Console.WriteLine("\n\n\n\t\t\t**** I hope dear you enjoyed the show that was the little bit about the type casting");
//            Console.WriteLine("\n\n\n\t\t**** One thing should be crystal clear; typecasting is really useful when receiving user's input");
//            return;
//        }


//        static void usersInput()
//        {
//            //One thing about type casting that you should make crystal clear is that we will receives the sting like js and we will typecast them.
//            Console.WriteLine("Dear kindly enter your name ");
//            String name = Console.ReadLine();
//            //int age = Console.ReadLine(); //will display the error;
//            Console.WriteLine("Dear kidly enter your age ");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Dear " + name + " with age " + age + " you are wellcome to the show");

//            Console.WriteLine("Dear can you please enter number here ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("\n");
//            for(int i=1;i<=num && num<=10;i++)
//            {
//                for (int j = 1; j <= i; j++)
//                    Console.Write("*");
//                Console.Write("\n");
//            }

//            return;
//        }

//        static void basicAirthmatic()
//        {

//            int num = 2;
//            Console.WriteLine("The orginal value of num => " + num);
//            num = num + 1;
//            num += 1;
//            num++;
//            Console.WriteLine("After applying the basic + operations we get num's value => " + num);

//            num = num - 1;
//            num -= 1;
//            num--;

//            Console.WriteLine("After applying the basic - operations we get num's value => " + num);

//            num = num * 2;
//            num *= 2;

//            Console.WriteLine("After applying the basic * operations we get num's value => " + num);

//            num = num / 2;
//            num /= 2;
//            Console.WriteLine("After applying the basic / operations we get num's value => " + num);


//            int rem = num % 2;
//            Console.WriteLine("The reminder % of the " + num + " % 2 is " + rem);

//            Console.WriteLine("\n\t\t Here we saw the basic airthmatic operations +,-,*,/,%");


//            Console.ReadKey();
//            return;
//        }

//        static void getRandom()
//        {
//            Random random = new Random();
//            //Console.WriteLine(random);
//            int num1 = random.Next(1, 7);
//            int num2 = random.Next(1, 7);
//            int num3 = random.Next(1, 7);

//            //we can also generate the double data type random number;
//            //double num4 = random.NextDouble(1.0, 7.0);
//            //Console.WriteLine(num4);


//        prev:
//            Console.WriteLine("Dear enter the total number of dies to roll 1,2 or 3");
//            int dies = Convert.ToInt32(Console.ReadLine());

//            if (dies > 3 || dies <= 0)
//            {
//                Console.WriteLine("Oop's invalid re_eneter the number");
//                goto prev;
//            }

//            switch(dies)
//            {
//                case 1:
//                    {
//                        Console.WriteLine("The number is " + num1);
//                        break;
//                    }
//                case 2:
//                    {
//                        Console.WriteLine("The first number is " + num1);
//                        Console.WriteLine("The second number is " + num2);
//                        break;
//                    }
//                case 3:
//                    {
//                        Console.WriteLine("The first number is " + num1);
//                        Console.WriteLine("The second number is " + num2);
//                        Console.WriteLine("The third number is " + num3);

//                        break;
//                    }
//            }

//            Console.WriteLine("\n\t\t****So here we learn about how to generate the random number;\n\t\t point should be clear for random.Next(n1,n2)\n" +
//                "\t\tThe n2 will be excluded\n" +
//                "\t\tThe number will be n1 to n2-1");



//            Console.ReadKey();
//            return;
//        }

//        static void calculateHypotenus()
//        {
//            Console.WriteLine("\t\t\t(*** Kindly enter the required data to calculate the hypotenus of the triangle ***)");

//            Console.WriteLine("Enter the side A: ");
//            double A = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter the side B: ");
//            double B = Convert.ToDouble(Console.ReadLine());

//            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

//            Console.WriteLine("So; the hypotenus of the triangle is " + C);

//            Console.ReadKey();
//        }

//        static void stringMethods()
//        {
//            Console.WriteLine("\t\t\t(****Here we will see the string methods****)");
//            const String name = "Mohsin";
//            Console.WriteLine("So; dear the original string is: " + name);
//            Console.WriteLine("On this we are going to perform string methods");

//            Console.WriteLine("IN Upper Case "+name.ToUpper());
//            Console.WriteLine("IN Lower Case "+name.ToLower());
//            Console.WriteLine("Replace(v1,v2) " + name.Replace('M', 'H'));
//            Console.WriteLine("Insert(idx,value)  (can be character or string) " + name.Insert(0, "Hi "));
//            Console.WriteLine("String's length string.length "+ name.Length);
//            Console.WriteLine("Substring(startIdx,endIdx) (endIdx will be excluded startIdx to endIdx-1): " + name.Substring(0,2));


//            Console.WriteLine("\n\n\t\t\tSo; dear the original string is and the strings are immuatable: " + name);





//            Console.ReadKey();
//            return;
//        }

//        static void Main()
//        {
//            //String name = "Mohsin";
//            //double age = 21.2;
//            //Console.WriteLine("Hello Mr. "+name+"! How are you and your age is "+age);
//            //Console.WriteLine("Sum = "+ sum(2, 2));
//            //Console.WriteLine("The factorial of the number 5 is " + factorial(5));
//            //Console.WriteLine("The number 2 is prime " + isPrime(2));
//            //typeCasting();
//            //usersInput();
//            //basicAirthmatic();
//            //getRandom();
//            //calculateHypotenus();
//            //stringMethods();
//        }
//    }
//}

//practice to check same name classes in namespace(same)
//namespace test1
//{
//    //Elements defined in the namespace can't be explicitly declared as private,protected,protected internal or private protected.
//    //Elements can only be public or internal; 
//    class mytest1
//    {
//        public void print()
//        {
//            Console.WriteLine("I am mytest1");
//            Console.ReadKey();
//        }
//        // Type 'mytest1' already defines a member called 'print' with the same parameter types.
//        //internal void print()
//        //{
//        //    Console.WriteLine("I am also in mytest1");
//        //    Console.ReadKey();
//        //}
//    }
//}
//namespace test2
//{
//    internal class mytest2
//    {
//        public void print()
//        {
//            Console.WriteLine("I am in mytest2");
//            Console.ReadKey();
//        }
//    }
//}


//namespace mainTst
//{
//    class Program
//    {
//        public static void Main()
//        {
//            test1.mytest1 mytestObj1 = new test1.mytest1();
//            mytestObj1.print();
//            test2.mytest2 mytestObj2 = new test2.mytest2();
//            mytestObj2.print();
//        }
//    }
//}



//abstract class's (that contains 
//namespace absPractice
//{
//    public abstract class Human
//    {
//        protected abstract void speak();
//        public abstract void hello();
//        //we can define the virtual function in the abstract class.
//        protected virtual void end()
//        {
//            Console.WriteLine("The end!");
//            Console.ReadKey();
//        }
//    }

//    class Man : Human
//    {
//        //we can't change the access modifer while overriding... otherwise error
//        //public override void speak()
//        protected override void speak()
//        {
//            Console.WriteLine("A Man is speaking...");
//        }
//        public override void hello()
//        {
//            //throw new NotImplementedException();

//                Console.WriteLine("HEllo");
//                speak();
//                Console.ReadKey();   
//        }
//        public void end()
//        {
//            Console.WriteLine("End in the child class");
//            Console.ReadKey();
//        }
//    }


using System;
using PublicClassLibrary1;
namespace practice { 
class Program
{
    public static void Main()
    {
            //Human h1 = Human(); //we cause an error
            //h1.hello();
            //Man m1 = new Man();
            //m1.hello();
            //m1.end();
            //Class1 obj = new Class1();
            //Console.WriteLine(obj.sayHi());
            //Console.ReadKey();
        }
    }
}



