using ConsoleUI.AccountsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.ApplicantsFolder
{
    public class Executive : IApplicant
    {
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
