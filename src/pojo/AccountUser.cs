using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class AccountUser
    {
        private String  account, password, userId;
        private bool status;

        public AccountUser( string account, string password,  bool status)
        {
            this.Account = account;
            this.Password = password;
            this.Status = status;
        }

        public AccountUser(string account, string password, bool status,String userId)
        {
            this.Account = account;
            this.Password = password;
            this.Status = status;
            this.userId = userId;
        }

        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public string UserId { get => userId; set => userId = value; }
        public bool Status { get => status; set => status = value; }
    }
}
