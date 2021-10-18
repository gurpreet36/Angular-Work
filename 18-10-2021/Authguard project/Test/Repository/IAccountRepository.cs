using Test.Model;

namespace Test.Repository
{
    public interface IAccountRepository
    {
        Account createUser(Account account);

        Account SearchUser(string usern, string pass);
        object GetSingleRecord(string username, string password);
    }
}