using ConsoleUI.ApplicantsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.AccountsFolder
{
    public class ExecutiveAccounts : IAccounts
    {
        public Employee Create(IApplicant person)
        {
            Employee employee = new Employee();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.Email = $"{person.FirstName}.{person.LastName}@acmecorp.com";

            employee.IsManager = true;
            employee.IsExecutive = true;

            return employee;
        }
    }
}
