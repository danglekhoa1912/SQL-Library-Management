using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management.src.pojo
{
    class Admin
    {
        private String admminId, adminName, phoneNumber, email;
        private int yearOfBirth;

        public Admin(string admminId, string adminName, string phoneNumber, string email, int yearOfBirth)
        {
            this.admminId = admminId;
            this.adminName = adminName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.yearOfBirth = yearOfBirth;
        }

        public string AdmminId { get => admminId; set => admminId = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
    }
}
