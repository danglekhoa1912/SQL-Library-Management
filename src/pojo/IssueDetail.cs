using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class IssueDetail
    {
        private String issueDetailId, bookId, issueId, statusBook;
        private int fine, quantily;
        DateTime returnDate;

        public IssueDetail(string issueDetailId, string bookId, string issueId, string statusBook, int fine, int quantily, DateTime returnDate)
        {
            this.IssueDetailId = issueDetailId;
            this.BookId = bookId;
            this.IssueId = issueId;
            this.StatusBook = statusBook;
            this.Fine = fine;
            this.Quantily = quantily;
            this.ReturnDate = returnDate;
        }

        public string IssueDetailId { get => issueDetailId; set => issueDetailId = value; }
        public string BookId { get => bookId; set => bookId = value; }
        public string IssueId { get => issueId; set => issueId = value; }
        public string StatusBook { get => statusBook; set => statusBook = value; }
        public int Fine { get => fine; set => fine = value; }
        public int Quantily { get => quantily; set => quantily = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
    }
}
