using ConsoleUI.ApplicantsFolder;

namespace ConsoleUI.AccountsFolder
{
    public class Accounts : IAccounts
    {
        public Employee Create(IApplicant person)
        {
            Employee employee = new Employee();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

            return employee;
        }
    }
}
