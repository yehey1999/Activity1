using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    abstract class Employee
    {
        // Non-Automatic Properties (Long Hand)
        /*
        private string name; // field
        private int id;
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        */


        // Automatic Properties (Short Hand)
        public int Id 
        { get; set; }

        public string Name 
        { get; set; }
        
        public double Salary
        { get; set; }
        
        public double Deduction
        { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateSalary(double days);

        public abstract double CalculateDeduction();

        public abstract double CalculateNetPay();

        public virtual void Display()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Salary: {0}", Salary);
        }

    }
}
