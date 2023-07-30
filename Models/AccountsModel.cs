﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public class AccountsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set;}
        public string? Notes { get; set; }

    }
}
