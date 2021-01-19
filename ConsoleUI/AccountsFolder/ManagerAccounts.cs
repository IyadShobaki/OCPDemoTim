using ConsoleUI.ApplicantsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.AccountsFolder
{
    public class ManagerAccounts : IAccounts
    {
        public Employee Create(IApplicant person)
        {
            Employee employee = new Employee();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";

            employee.IsManager = true;

            return employee;
        }
    }
}
