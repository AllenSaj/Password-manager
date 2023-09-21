using PasswordManager.Models;
using PasswordManager.Repositories;
using PasswordManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PasswordManager.ViewModels
{
    public class DataEntryViewModel : ViewModelBase
    {
        private int _id;
        private string _name;
        private string _username;
        private string _email;
        private string _url;
        private string _password;
        private string _notes;
        private string _errorMessage;
        private bool _isViewVisible;
        public bool _isSaved;
        private readonly IAccountsRepository accountsRepository;
        private int mode; //Mode 1: Create account, Mode 2: Edit account

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get => _isViewVisible;
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        public bool IsSaved
        {
            get => _isSaved;
            set
            {
                _isSaved = value;
                OnPropertyChanged(nameof(IsSaved));
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public DataEntryViewModel()
        {
            mode = 1;
            Id = 0;
            accountsRepository = new AccountsRepository();
            SaveCommand = new ViewModelCommand(Save, CanSave);
            CancelCommand = new ViewModelCommand(Cancel);
            IsViewVisible = true;
            IsSaved = false;
        }

        public DataEntryViewModel(int id, String name, String username, String email, String url, String password, String notes)
        {
            mode = 2;
            accountsRepository = new AccountsRepository();
            SaveCommand = new ViewModelCommand(Save, CanSave);
            CancelCommand = new ViewModelCommand(Cancel);
            IsViewVisible = true; IsSaved = false;
            Name = name; Username = username; Password = password;
            Email = email; Url = url; Notes = notes; Id = id;
        }

        private void Save(object obj)
        {
            AccountsModel account = new AccountsModel
            {
                Id = Id,
                Name = Name,
                Username = Username,
                Password = Password,
                Email = Email,
                Website = Url,
                Notes = Notes
            };
            try
            {  
                if (mode == 2) {
                    accountsRepository.Edit(account);
                    MessageBox.Show("Record successfully Updated.");  
                }
                else {
                    accountsRepository.Add(account);
                    MessageBox.Show("Record successfully Added."); 
                }
                IsSaved = true;
            }
            catch (Exception ex)
            {
                if (mode == 2) { MessageBox.Show("Error occurred while updating. " + ex); }
                else { MessageBox.Show("Error occurred while adding. " + ex); }
            }
            
            Cancel(obj);
        }

        private bool CanSave(object obj)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "Enter information in all required fields";
                return false;
            }
            return true;
        }

        private void Cancel(object obj)
        {
            IsViewVisible = false;

        }
    }
}
