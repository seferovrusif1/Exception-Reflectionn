using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Models
{
    internal class User1
    {
        private int _id { get; set; } =0;
        private string _name { get; set; } = "";
        private static int _age { get; set; } = 0;
        public string a;
        public static void ChangeAge(int age) 
        {
            _age = age;
        }

        
    }
}
