using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Programmer : Employee
    {

        public string Specialization
        { get; set; }

        public Programmer()
        {
        }

        public Programmer(int id, string name, string specialization) : base(id, name)
        {
            // you can either used this one, or the base keyword to call the base/parent constructor 
            // 
            // Id = id;
            // Name = name;

            Specialization = specialization;
        }

        public override void Display()
        {
            // can also be used to display the parent display method
            // base.Display();
            Console.WriteLine("Id:\t\t {0}", Id);
            Console.WriteLine("Name:\t\t {0}", Name);
            // Console.WriteLine("Salary: {0}", Salary);
            Console.WriteLine("Specialization:  {0}", Specialization);
        }

        public override double CalculateDeduction()
        {
            return (Salary * 0.05) + (Salary * 0.03) + (Salary * 0.08) + (Salary * 0.03);
        }

        public override double CalculateNetPay()
        {
            Deduction = CalculateDeduction();
            return Salary - Deduction;
        }

        public override double CalculateSalary(double days)
        {
            Salary = days * 950;
            return Salary;
        }
    }
}
