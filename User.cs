using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Lesson4Exercises
{
    public class User : Employee
    {
        public string Email { get; set; }

        public float Weight { get; set; }

        public short Increase { get; set; }

        public override string ToString()
        {
            string pesel = ConvertPeselToString();
            return $"User : Id = {Id}, FirstName = {FirstName}, Surname = {Surname}, Age = {Age}, Gender = {Gender}, Pesel = {pesel}, Email = {Email}, Weight = {Weight}, Increase = {Increase}";
        }
    }
}
