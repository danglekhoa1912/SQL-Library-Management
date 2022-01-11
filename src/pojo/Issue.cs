using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class Issue
    {
        private String issueId, accountUserId, accountAdminId;
        private DateTime issueDate, deadlineDate;
        private int totalMoney;
        private bool status;

        public Issue(string issueId, string accountUserId, string accountAdminId, DateTime issueDate, DateTime deadlineDate, int totalMoney, bool status)
        {
            this.IssueId = issueId;
            this.AccountUserId = accountUserId;
            this.AccountAdminId = accountAdminId;
            this.IssueDate = issueDate;
            this.DeadlineDate = deadlineDate;
            this.TotalMoney = totalMoney;
            this.Status = status;
        }

        public string IssueId { get => issueId; set => issueId = value; }
        public string AccountUserId { get => accountUserId; set => accountUserId = value; }
        public string AccountAdminId { get => accountAdminId; set => accountAdminId = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public DateTime DeadlineDate { get => deadlineDate; set => deadlineDate = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }
        public bool Status { get => status; set => status = value; }
    }
}
