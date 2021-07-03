using System;
using System.Collections.Generic;
using System.Text;

namespace MyMainApp
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee (string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void work()
        {
            Console.WriteLine("I'm working");
        }

        pubic void Pause()
        {
           Console.WriteLine("I'm having a break")
        }


    }
}
