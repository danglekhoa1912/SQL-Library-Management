using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class Book
    {
        private String  bookName, author, publisher;
        private int quantily, publishingYear;

        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Quantily { get => quantily; set => quantily = value; }
        public int PublishingYear { get => publishingYear; set => publishingYear = value; }
        
        public Book(String bookName,int quantily,String author,int publishingYear, String publisher)
        {
            this.bookName = bookName;
            this.quantily = quantily;
            this.author = author;
            this.publishingYear = publishingYear;
            this.publisher = publisher;
        }
    }
}
