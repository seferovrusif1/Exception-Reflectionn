using ExceptionTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExceptionTask.Models
{
    internal class User
    {
        private string _name;
        private int _age;
        private string _phoneNumber;
        private string _password;
        public string Name 
        {
            get=>_name;
            set
            {
                if (value.Length < 3 || value.Length > 30) throw new InvalidNameException("Ad sehvdir");

            }
        }
        public int Age
        {
            get=>_age;
            set
            {
                if (value < 1 || value > 255) throw new InvalidAgeException("Yas yanlisdir");

            }
        }
        public string PhoneNuber
        {
            get => _phoneNumber;
            set 
            {
                Regex reg = new Regex(@"^\+994-(50)|(51)|(55)|(70)|(77)-[0-9]{3}-[0-9]{2}-[0-9]{2}$");
                if (!(reg.IsMatch(value)))
                {
                    throw new InvalidPhoneNumber("Number sehvdir!");
                }
                else
                {
                _phoneNumber = value;
                    
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {


                Regex reg = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

                if (!(reg.IsMatch(value)))
                {
                    throw new PasswordException("kod sehvdir!");
                }
                _password = value;
            }
        }
        //public User(string name,byte age,string phoneNumber,string password)
        //{
            //bool b = false;
            //bool c = false;
            //if (password.Length>7)
            //{
            //    foreach (var item in password)
            //    {
            //        if (char.IsDigit(item))
            //        {
            //            b = true;
            //        }
            //        if (char.IsUpper(item))
            //        {
            //            c = true;
            //        }
            //    }
                
            //}
            //if (!b || !c) throw new PasswordException();
        //}
    }
}
