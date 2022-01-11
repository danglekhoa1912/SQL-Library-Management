using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class User
    {
        private String userId, userName,  email, studentId, phoneNumber;
        private DateTime birthDay;

        public User( string userName, string email, string studentId, DateTime birthDay, String phoneNumber)
        {
            this.userName = userName;
            this.email = email;
            this.studentId = studentId;
            this.birthDay = birthDay;
            this.phoneNumber = phoneNumber;
        }

        public string UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string StudentId { get => studentId; set => studentId = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
