using Test.Model;
using Test.Context;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;

namespace Test.Repository
{
    public class AccountRepository : IAccountRepository
    {
        AccountDbContext accountDbContext;
        public AccountRepository(AccountDbContext _accountDbContext)
        {
            accountDbContext = _accountDbContext;
        }
        Account IAccountRepository.createUser(Account account)
        {
            accountDbContext.Add(account);
            accountDbContext.SaveChanges();
            return account;
        }

        object IAccountRepository.GetSingleRecord(string username, string password)
        {
           var result =accountDbContext.accounts.FirstOrDefault(ctr=>ctr.Username==username && ctr.Password==password);
            if(result==null)
            {
                return null;
            }
            return result;
        }

        Account IAccountRepository.SearchUser(string usern, string pass)
        {
            var temp = accountDbContext.accounts.FirstOrDefault(t=>t.Username==usern && t.Password==pass);
            return temp;
        }
    }
}