using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public class UserAccountModel
    {
        public string Username { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}
