using System;
using PasswordManager.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using System.Collections;
using System.Net;

namespace PasswordManager.Repositories
{
    internal class AccountsRepository : RepositoryBase, IAccountsRepository
    {

        void IAccountsRepository.Add(AccountsModel account)
        {
            var connection = GetConnection();
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into [Accounts]([Name], [Username], [Email], [Password], [Website], [Notes]) values (@name, @username, @email, @password, @website, @notes)";
                command.Parameters.Add("@name", SqlDbType.Int).Value = account.Name;
                command.Parameters.Add("@username", SqlDbType.Int).Value = account.Username;
                command.Parameters.Add("@email", SqlDbType.Int).Value = account.Email;
                command.Parameters.Add("@password", SqlDbType.Int).Value = account.Password;
                command.Parameters.Add("@website", SqlDbType.Int).Value = account.Website;
                command.Parameters.Add("@notes", SqlDbType.Int).Value = account.Notes;
                command.ExecuteNonQuery();
            }
        }

        void IAccountsRepository.Edit(AccountsModel oldAccount, AccountsModel newAccount)
        {
            throw new NotImplementedException();
        }

        void IAccountsRepository.Remove(int id)
        {
            var connection = GetConnection();
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from [Accounts] where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        ObservableCollection<AccountsModel> IAccountsRepository.GetByAll()
        { 
            var connection = GetConnection();
            ObservableCollection<AccountsModel> _accounts = new ObservableCollection<AccountsModel>();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };

                        _accounts.Add(account);
                    }
                }
            }
            return _accounts;
        }

        AccountsModel IAccountsRepository.GetByEmail(string email)
        {
            var connection = GetConnection();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts] where Email=@email";
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        return account;
                    }
                }
            }
            return null;
        }

        AccountsModel IAccountsRepository.GetById(int id)
        {
            var connection = GetConnection();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts] where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        return account;
                    }
                }
            }
            return null;
        }

        AccountsModel IAccountsRepository.GetByUsername(string username)
        {
            var connection = GetConnection();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts] where Username=@username";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        return account;
                    }
                }
            }
            return null;
        }

        AccountsModel IAccountsRepository.GetByWebsite(string website)
        {
            var connection = GetConnection();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts] where Website=@website";
                command.Parameters.Add("@website", SqlDbType.NVarChar).Value = website;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        return account;
                    }
                }
            }
            return null;
        }

        public AccountsModel GetByName(string name)
        {
            var connection = GetConnection();
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Accounts] where Name=@name";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountsModel account = new AccountsModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        return account;
                    }
                }
            }
            return null;
        }
    }
}
 