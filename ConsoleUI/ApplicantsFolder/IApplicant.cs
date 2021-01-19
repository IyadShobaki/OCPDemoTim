using ConsoleUI.AccountsFolder;

namespace ConsoleUI.ApplicantsFolder
{
    public interface IApplicant
    {
        IAccounts AccountProcessor { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}