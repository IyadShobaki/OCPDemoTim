using ConsoleUI.ApplicantsFolder;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> applicants = new List<IApplicant>()
            {
                new Executive { FirstName = "Tim", LastName = "Corey" },
                new Manager { FirstName = "Sue", LastName = "Storm" },
                new Applicant { FirstName = "Mike", LastName = "Smith" }
            };

            List<Employee> employees = new List<Employee>();

            foreach (var a in applicants)
            {
                employees.Add(a.AccountProcessor.Create(a));
            }

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} - {e.LastName}, Email: {e.Email} IsManager: {e.IsManager} IsExecutive {e.IsExecutive}");
            }


            Console.ReadKey();
        }
    }
}
