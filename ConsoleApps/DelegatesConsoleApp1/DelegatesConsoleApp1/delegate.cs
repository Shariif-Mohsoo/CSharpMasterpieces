﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for List<>
using System.Collections.Generic;




namespace DelegatesConsoleApp1
{
    //creating the deletage
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //List<dataType> vriableName
        public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligibleToPromote)
        {

            foreach (Employee employee in employeeList)
            {
                //if(employee.Experience > 4)
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " is promoted");
                }
            }
        }
    }

    class Program
    {
        public static bool Promote(Employee emp)
        {
            return (emp.Experience >= 5);
        }
        //static void Main(string[] args)
        //{
        //    List<Employee> empList = new List<Employee>();
        //    empList.Add(new Employee()
        //        {
        //            ID = 101,
        //            Name = "Mary",
        //            Salary = 5000,
        //            Experience = 5
        //        }
        //     );
        //    empList.Add(new Employee()
        //    {
        //        ID = 102,
        //        Name = "Mike",
        //        Salary = 4000,
        //        Experience = 4
        //    }
        //     );
        //    empList.Add(new Employee()
        //    {
        //        ID = 103,
        //        Name = "John",
        //        Salary = 6000,
        //        Experience = 5
        //    }
        //     );
        //    empList.Add(new Employee()
        //    {
        //        ID = 104,
        //        Name = "Todd",
        //        Salary = 3000,
        //        Experience = 3
        //    }
        //     );

        //    //creating the instance of delegate
        //    IsPromotable isPromotable = new IsPromotable(Program.Promote);

        //    Employee.PromoteEmployee(empList,isPromotable);
        //}
    }
}
