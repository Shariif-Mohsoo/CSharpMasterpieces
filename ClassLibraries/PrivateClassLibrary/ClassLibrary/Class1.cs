using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //internal class Class1 //it will not be accessible outside the assembly/project.
    //private class Class1 //it should not be private otherwise build failed.
    //protected class Class1 //it should not be protected otherwise build failed.
    //protected internal class Class1 //it should not be protected internal otherwise build failed.
    public class Class1
    {
        public string print()
        {
            return "Hi You Press me!";
        }
    }
}
