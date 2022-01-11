using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class AccountAdmin
    {
        private String accountAdminId, account, password, admminId;

        public AccountAdmin(string accountAdminId, string account, string password, string admminId)
        {
            this.accountAdminId = accountAdminId;
            this.account = account;
            this.password = password;
            this.admminId = admminId;
        }

        public string AccountAdminId { get => accountAdminId; set => accountAdminId = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public string AdmminId { get => admminId; set => admminId = value; }
    }
}
