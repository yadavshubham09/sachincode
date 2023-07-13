using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyProject.Models;

namespace DummyProject.Repository
{
    internal interface IAccountRepository
    {
        IEnumerable<Account> GetAllDetails();
        int Register(Account account);
        int SignIn(String UserName, String Password);
    }
}
