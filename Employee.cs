using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Lesson4Exercises
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public byte Age { get; set; }

        public Gender Gender { get; set; }

        public byte[] Pesel { get; set; }

        public override string ToString()
        {
            string pesel = ConvertPeselToString();
            return $"Employee : Id = {Id}, FirstName = {FirstName}, Surname = {Surname}, Age = {Age}, Gender = {Gender}, Pesel = {pesel}";
        }

        protected string ConvertPeselToString()
        {
            return string.Join("", Pesel);
        }
    }
}
