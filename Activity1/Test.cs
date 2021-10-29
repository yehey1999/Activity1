using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    class Test
    {
        public Test()
        {

        }

        public void Application()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("[1] Doctor");
                Console.WriteLine("[2] Programmer");
                Console.WriteLine("[3] Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter ID Number:\t\t");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name:\t\t\t");
                string name = Console.ReadLine();
                Console.Write("Enter Field of Specialization:  ");
                string specialization = Console.ReadLine();
                Console.Write("Number of days worked:\t\t");
                double days = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        Doctor doctor = new Doctor(id, name, specialization);
                        doctor.Display("Doctor's Information");
                        Console.WriteLine("Salary:\t\t {0}", doctor.CalculateSalary(days));
                        Console.WriteLine("Deduction:\t {0}", doctor.CalculateDeduction());
                        Console.WriteLine("Net Pay:\t {0}", doctor.CalculateNetPay());
                        break;
                    case 2:
                        Programmer programmer = new Programmer(id, name, specialization);
                        programmer.Display();
                        Console.WriteLine("Salary:\t\t {0}", programmer.CalculateSalary(days));
                        Console.WriteLine("Deduction:\t {0}", programmer.CalculateDeduction());
                        Console.WriteLine("Net Pay:\t {0}", programmer.CalculateNetPay());
                        break;
                    case 3:
                        isContinue = false;
                        break;
                    default:
                        break;
                }
                Console.Write("Press enter to continue....");
                Console.ReadLine();
            }
        }
    }
}
