﻿using PasswordManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManager.Views
{
    /// <summary>
    /// Interaction logic for AccountsView.xaml
    /// </summary>
    public partial class AccountsView : UserControl 
    { 
        public AccountsView()
        {
            InitializeComponent();
            AccountsViewModel viewModel = new AccountsViewModel();
            DataContext = viewModel;
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddRecordExpander.IsExpanded = !AddRecordExpander.IsExpanded;
        }

        private void CancelButon_Click(object sender, RoutedEventArgs e)
        {
            // Clear input controls and collapse the Expander
            AddTextBox.Text = string.Empty;
            AddRecordExpander.IsExpanded = false;
        }
    }
}