using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DummyProject.Models;

namespace DummyProject.Repository
{
    public class AccountRepository : IAccountRepository
    {
        DBDummyProjectEntities DBDummyProject;
        public AccountRepository() { DBDummyProject = new DBDummyProjectEntities(); }
        int IAccountRepository.Register(Account account)
        {
            if(account == null) return 0;
            else
            {
                DBDummyProject.Accounts.Add(account); DBDummyProject.SaveChanges();
                return 1;
            }
        }

        IEnumerable<Account> IAccountRepository.GetAllDetails()
        {
            return DBDummyProject.Accounts.ToList(); 
        }

        int IAccountRepository.SignIn(string UserName, string Password)
        {
            var user = DBDummyProject.Accounts.FirstOrDefault(u => u.UserName == UserName && u.Password == Password);

            if(user == null) return 0; 
            else return 1;
        }
    }
}