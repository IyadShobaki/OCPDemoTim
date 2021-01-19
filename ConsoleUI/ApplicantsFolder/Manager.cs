using ConsoleUI.AccountsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.ApplicantsFolder
{
    public class Manager : IApplicant
    {
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
