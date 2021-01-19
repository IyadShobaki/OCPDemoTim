using ConsoleUI.ApplicantsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UsingDelegates
{
    public class AccountsModel
    {
        public Employee Create(Applicant applicant, 
            Func<Applicant, Employee> handleAccount)
        {
            return handleAccount(applicant);
        }
    }
}
