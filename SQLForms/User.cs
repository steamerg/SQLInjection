using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLForms
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(int userId, string username, string passwordHash, string email)
        {
            UserId = userId;
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
        }

        public override string ToString()
        {
            return $"UserId: {UserId}, Username: {Username}, Email: {Email}";
        }
    }
}
