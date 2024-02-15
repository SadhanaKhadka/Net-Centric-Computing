using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NccLabSadhana
{
    class Employee
    {
        int eid;
        string name;
        double salary;
        string department;
        public Employee(int eid, string name, double salary, string department)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
            this.department = department;
        }
        //public string this[int idx]  does not work for name and others
        public object this[int idx]
        {
            get
            {
                if (idx == 0)
                    return this.eid;
                else if (idx == 1)
                    return this.name;
                else if (idx == 2)
                    return this.salary;
                else if (idx == 3)
                    return this.department;
                else
                    return "Invalid index";
            }
            set
            {
                if (idx == 0)
                    this.eid = (int)value;
                else if (idx == 1)
                    this.name = (string)value;
                else if (idx == 2)
                    this.salary = (double)value;
                else if (idx == 3)
                    this.department = (string)value;
                else
                    Console.WriteLine("Invalid index");
            }
        }
    }
    internal class Indexers
    {
        static void Main(string[] args) 
       {
            Employee emp1;
            emp1= new Employee(101, "Hana", 45000.5, "Bio");
                emp1[2] = 90000.5; //only allowed when theser is set operator
            Console.WriteLine("Name=" + emp1[1]);
            Console.WriteLine("Salary="+ emp1[2]);

        }
    }
}
