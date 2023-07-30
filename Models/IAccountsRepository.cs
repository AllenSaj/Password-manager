using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public interface IAccountsRepository
    {
        void Add(AccountsModel accountsModel);
        void Edit(AccountsModel oldAccount, AccountsModel newAccount);
        void Remove(int id);
        AccountsModel GetById(int id);
        AccountsModel GetByUsername(string username);
        AccountsModel GetByEmail(string email);
        AccountsModel GetByWebsite(string website);
        AccountsModel GetByName(string name);

        ObservableCollection<AccountsModel> GetByAll();
    }
}
