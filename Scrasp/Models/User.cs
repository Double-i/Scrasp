using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class User : IdentifiableEntity
    {
        private String userName;
        private String password;
        private String role;

        public User(string userName, string password, string role)
        {
            this.userName   = userName;
            this.password   = password;
            this.role       = role;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public override string ToString()
        {
            return string.Format("User id: {0} with username: {1}", this.Id, this.UserName);
        }
    }
}