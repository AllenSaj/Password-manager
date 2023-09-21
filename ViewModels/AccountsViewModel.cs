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
using PasswordManager.Views;

namespace PasswordManager.ViewModels
{
    public class AccountsViewModel: ViewModelBase
    {
        private ObservableCollection<AccountsModel> _accountsList;
        private readonly IAccountsRepository accountsRepository;
        private AccountsModel _account;

        public ObservableCollection<AccountsModel> AccountsList {
            get { return _accountsList;  }
            set
            {
                _accountsList = value;
                OnPropertyChanged(nameof(AccountsList));
            }
        }

        public AccountsModel Account
        {
            get { return _account; }
            set
            {
                _account = value;
                OnPropertyChanged(nameof(_account));
            }
        }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand CopyCommand { get; }

        public AccountsViewModel()
        {
            Account = null;
            accountsRepository = new AccountsRepository();
            AddCommand = new ViewModelCommand (Add);
            EditCommand = new ViewModelCommand(Edit);
            DeleteCommand = new ViewModelCommand (Remove);
            CopyCommand = new ViewModelCommand(Copy);
            ResetData();
        }


        public void ResetData()
        {
            AccountsList = new ObservableCollection<AccountsModel>();
            GetAll();
        }

        public void Add(object obj)
        {
            DataEntryView dataView = new DataEntryView();
        }
        
        private void Remove(object obj)
        {
            int id = Convert.ToInt32(obj);
            if (id != 0 && MessageBox.Show("Confirm delete of this record?", "Student", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    accountsRepository.Remove(id);
                    MessageBox.Show("Record successfully deleted.");
                    foreach (AccountsModel account in AccountsList)
                    {
                        if (account.Id == id)
                        {
                            _accountsList.Remove(account);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting. " + ex.InnerException);
                }
            }
        }

        public void Edit(object param)
        {
            int id = Convert.ToInt32(param);
            Account = accountsRepository.GetById(id);
            DataEntryViewModel dataViewModel = new DataEntryViewModel(Account.Id, Account.Name, Account.Username ?? "", Account.Email ?? "", Account.Website ?? "", Account.Password, Account.Notes ?? "");
            DataEntryView dataEntryView = new DataEntryView();
            dataEntryView.DataContext = dataViewModel;
        }

        public void Copy(object param)
        {
            string password = param as string;
            Clipboard.SetText(password);
        }
         
        public void GetAll()
        { 
            AccountsList = accountsRepository.GetByAll(); 
        }

        public void AddToList(AccountsModel account)
        {
            AccountsList.Add(account);
        }
    }
}
