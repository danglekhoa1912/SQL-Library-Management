using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library_Management.src.services
{
    internal class isValidInput
    {
        public bool isValidName(String s)
        {
            return Regex.IsMatch(s,"[0-9]") || Regex.IsMatch(s, "[!@#$%&*()_+=|<>?{}:;'.,/\\[\\]\"~-]");
        }
        public static String removeCharAt(String s, int pos, int i)
        {
            return s.Substring(0, pos) + s.Substring(pos + i);
        }
        public bool isValidUserName(String s)
        {
            return Regex.IsMatch(s,"\\s") || Regex.IsMatch(s, "[!@#$%&*()_+=|<>?{}:;'.,/\\[\\]\"~-]") || s.Length>=20? true : false ; 
        }
        public bool isValidPassword(String s)
        {
            return Regex.IsMatch(s, "[!@#$%&*()_+=|<>?{}:;'.,/\\[\\]\"~-]") && Regex.IsMatch(s, "[0-9]") && s.Length>=8 && Regex.IsMatch(s, "[a-z]") && Regex.IsMatch(s, "[A-Z]");
        }
        public bool isValidStdId(String s)
        {
            return Regex.IsMatch(s, "[0-9]") && s.Length==10;
        }
        public bool isValidMoblie(String s)
        {
            return Regex.IsMatch(s, "[0-9]") && s.Length == 10;
        }
        public bool isValidEmail(String s)
        {
            return Regex.IsMatch(s, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static String upperCaseFirstLetter(String s)
        {
            s = s.ToLower();
            String firstLetter = s.Substring(0, 1);
            String secondLetter = s.Substring(1);
            return firstLetter.ToUpper() + secondLetter;
        }
        public String styleString(String s)
        {
            s = s.Trim();
            while (s.IndexOf("  ") != -1)
            {
                s = removeCharAt(s, s.IndexOf("  ") + 1, 1);
            }
            String[] ch = s.Split(' ');
            s = "";
            foreach (String i in ch)
            {
                s += upperCaseFirstLetter(i) + " ";
            }
            return s.Substring(0, s.Length - 1);
        }


        public String unAccent(String s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public bool isValidYear(String s)
        {
            int i;
            try
            {
                i = int.Parse(s);
            }
            catch (Exception)
            {
                return false;
            }
            return Regex.IsMatch(s,"[0-9]") && i>1000 && i<=DateTime.Now.Year;
        }
    }
}
