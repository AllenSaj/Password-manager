using FontAwesome.Sharp;
using PasswordManager.Models;
using PasswordManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PasswordManager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;
        private readonly IUserRepository userRepository;

        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }

            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }

            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }

            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }

        public IconChar Icon
        {
            get
            {
                return _icon;
            }

            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        public ICommand ShowAccountsViewCommand { get; }
        public ICommand ShowSecurityViewCommand { get; }
        public ICommand ShowSettingsViewCommand { get; }

        public MainViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            
            //Initialise command
            ShowAccountsViewCommand = new ViewModelCommand(ExecuteShowAccountsViewCommand);
            ShowSecurityViewCommand = new ViewModelCommand(ExecuteShowSecurityViewComman);
            ShowSettingsViewCommand = new ViewModelCommand(ExecuteShowSettingsViewCommand);

            //Default view
            ExecuteShowAccountsViewCommand(null);

            LoadCurrentUserData();
        }

        private void ExecuteShowSettingsViewCommand(object obj)
        {
            CurrentChildView = new SettingsViewModel();
            Caption = "Settings";
            Icon = IconChar.Cogs;
        }

        private void ExecuteShowSecurityViewComman(object obj)
        {
            CurrentChildView = new SecurityViewModel();
            Caption = "Security";
            Icon = IconChar.BookOpen;
        }

        private void ExecuteShowAccountsViewCommand(object obj)
        {
            CurrentChildView = new AccountsViewModel();
            Caption = "Accounts";
            Icon = IconChar.UserGroup;
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = $"Welcome {user.Username.ToUpper()}";
                CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                CurrentUserAccount.Username = "Invalid user, not logged in";
                //Hide child views.
            }
        }
    }
}