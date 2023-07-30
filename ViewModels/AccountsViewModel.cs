using PasswordManager.Models;
using PasswordManager.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Security.Principal;

namespace PasswordManager.ViewModels
{
    public class AccountsViewModel: ViewModelBase
    {
        private ObservableCollection<AccountsModel> _accountsList;
        private readonly IAccountsRepository accountsRepository;

        public ObservableCollection<AccountsModel> AccountsList {
            get { return _accountsList;  }
            set
            {
                _accountsList = value;
                OnPropertyChanged(nameof(AccountsList));
            }
        }

        public ICommand AddCommand { get; }

        public AccountsViewModel()
        {
            accountsRepository = new AccountsRepository();
            _accountsList = new ObservableCollection<AccountsModel>();
            //AddCommand = new ViewModelCommand();
            GetAll();
        }

        public void ResetData()
        {
            throw new NotImplementedException();
        }

        public void Add(AccountsModel account)
        {
            accountsRepository.Add(account);
            _accountsList.Add(account);
        }
        public void Remove(int id)
        {
            if (MessageBox.Show("Confirm delete of this record?", "Student", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                try
                {
                    accountsRepository.Remove(id);
                    MessageBox.Show("Record successfully deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while saving. " + ex.InnerException);
                }
                finally
                {
                    GetAll();
                }
            }
        }

        public void Edit(AccountsModel oldAccount, AccountsModel newAccount)
        {
            accountsRepository.Edit(oldAccount, newAccount);
            _accountsList.Remove(oldAccount);
            _accountsList.Add(newAccount);
            
            
        }
         
        public void GetAll()
        { 
            _accountsList = accountsRepository.GetByAll();
            
        }
    }
}
