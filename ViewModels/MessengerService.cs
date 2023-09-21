using PasswordManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.ViewModels
{
    public class MessengerService
    {
        public event Action<AccountsModel> AccountSaved;

        public void PublishAccountSaved(AccountsModel account)
        {
            AccountSaved?.Invoke(account);
        }
    }
}
