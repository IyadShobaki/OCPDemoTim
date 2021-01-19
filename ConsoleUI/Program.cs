using ConsoleUI.ApplicantsFolder;
using ConsoleUI.UsingDelegates;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IApplicant> applicants = new List<IApplicant>()
            //{
            //    new Executive { FirstName = "Tim", LastName = "Corey" },
            //    new Manager { FirstName = "Sue", LastName = "Storm" },
            //    new Applicant { FirstName = "Mike", LastName = "Smith" }
            //};

            //List<Employee> employees = new List<Employee>();

            //foreach (var a in applicants)
            //{
            //    employees.Add(a.AccountProcessor.Create(a));
            //}

            //foreach (var e in employees)
            //{
            //    Console.WriteLine($"{e.FirstName} {e.LastName}, Email: {e.Email} IsManager: {e.IsManager} IsExecutive {e.IsExecutive}");
            //}

            AccountsModel model = new AccountsModel();
            var applicant = new Applicant()
            {
                FirstName = "Iyad",
                LastName = "Shobaki"
            };

            var manager = new Applicant()
            {
                FirstName = "Mike",
                LastName = "Smith"
            };
            var executive = new Applicant()
            {
                FirstName = "Sue",
                LastName = "Storm"
            };
            var basicEmployee = model.Create(applicant, GetBasicEmployee);
            var managerEmployee = model.Create(manager, GetManagerEmployee);
            var executiveEmployee = model.Create(executive, GetExecutiveEmployee);

            List<Employee> employees = new List<Employee>
            {
                basicEmployee,
                managerEmployee,
                executiveEmployee
            };


            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}, Email: {e.Email} IsManager: {e.IsManager} IsExecutive {e.IsExecutive}");
            }

            Console.ReadKey();
        }

        public static Employee GetBasicEmployee(Applicant applicant)
        {
            Employee employee = new Employee
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@acme.com"
            };

            return employee;
        }

        public static Employee GetManagerEmployee(Applicant applicant)
        {
            Employee employee = new Employee
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@acmecorp.com",

                IsManager = true
            };

            return employee;
        }
        public static Employee GetExecutiveEmployee(Applicant applicant)
        {
            Employee employee = new Employee
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName}.{applicant.LastName}@acmecorp.com",

                IsManager = true,
                IsExecutive = true
            };

            return employee;
        }
    }
}
