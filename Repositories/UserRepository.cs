﻿using PasswordManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PasswordManager.Repositories
{
    internal class UserRepository : RepositoryBase, IUserRepository
    {
        void IUserRepository.Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [User] where username=@username and [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() != null;
            }
            return validUser;
        }

        void IUserRepository.Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserModel> IUserRepository.GetByAll()
        {
            throw new NotImplementedException();
        }

        UserModel IUserRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        UserModel IUserRepository.GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
