using ConsoleUI.ApplicantsFolder;

namespace ConsoleUI.AccountsFolder
{
    public interface IAccounts
    {
        Employee Create(IApplicant person);
    }
}