using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Doctor : Employee
    {
        
        public string Specialization 
        { get; set; }

        public Doctor()
        {

        }

        public Doctor(int id, string name, string specialization): base (id, name)
        {
            // you can either used this one, or the base keyword to call the base/parent constructor
            //
            // Id = id;
            // Name = name;

            Specialization = specialization;
        }

        public void Display(string message)
        {
            Console.WriteLine(message);
            // can also be used to display the parent display method
            // base.Display();
            Console.WriteLine("Id:\t\t {0}", Id);
            Console.WriteLine("Name:\t\t {0}", Name);
            // Console.WriteLine("Salary: {0}", Salary);
            Console.WriteLine("Specialization:  {0}", Specialization);
        }

        public override double CalculateDeduction()
        {
            double deduction;
            if (Salary <= 10000)
                deduction = (Salary * 0.03) + (Salary * 0.02) + (Salary * 0.05) + (Salary * 0.01);
            else if (Salary <= 20000)
                deduction = (Salary * 0.05) + (Salary * 0.04) + (Salary * 0.1) + (Salary * 0.025);
            else if (Salary <= 30000)
                deduction = (Salary * 0.07) + (Salary * 0.07) + (Salary * 0.15) + (Salary * 0.05);
            else
                deduction = (Salary * 0.1) + (Salary * 0.1) + (Salary * 0.3) + (Salary * 0.08);
            return deduction;
        }

        public override double CalculateNetPay()
        {
            Deduction = CalculateDeduction();
            return Salary - Deduction;
        }

        public override double CalculateSalary(double days)
        {
            switch (Specialization)
            {
                case "Pediatrician":
                    Salary = days * 2050;
                    break;
                case "Ob-Gynecologist":
                    Salary = days * 2650;
                    break;
                case "Neurologist":
                    Salary = days * 6575;
                    break;
            }
            return Salary;
        }
    }
}
