using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Week2Lesson4Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 2 Lesson 4 - Exercises" + Environment.NewLine);s

            #region Exercise 1

            Console.WriteLine("Exercise 1");

            Exercise1();

            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 2

            Console.WriteLine("Exercise 2");

            Exercise2();

            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 3

            Console.WriteLine("Exercise 3");

            Exercise3(2, 5);

            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 4

            // Without write in console

            #endregion

            #region Exercise 5

            Exercise5();

            #endregion
        }

        public static void Exercise1()
        {
            Employee employee = new Employee { Id = 1, Age = 26, FirstName = "Jan", Surname = "Kowalski", Gender = Gender.Male, Pesel = new byte[] { 1, 3, 4, 2, 5, 8, 1, 7, 9, 5, 1 } };
            Console.WriteLine(employee.ToString());
        }

        public static void Exercise2()
        {
            char[] charArray = new char[3] { 'z', '2', 'g' };

            foreach (char character in charArray.Reverse())
                Console.WriteLine(character);
        }

        public static void Exercise3(double a, double b)
        {
            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Rectangle diagonal for {a} and {b} equals {Math.Round(diagonal, 3)}");
        }

        public static void Exercise4()
        {
            byte a = 10;
            string b = "Szkoła Dotneta";
            float c = 12.5f;
        }

        public static void Exercise5()
        {
            int id = GetId();

            string firstName = GetFirstName();

            string surname = GetSurname();

            byte age = GetAge();

            Gender gender = GetGender();

            byte[] pesel = GetPesel();

            string email = GetEmail();

            float weight = GetWeight();

            short increase = GetIncrease();

            User user = new User
            {
                Id = id,
                FirstName = firstName,
                Surname = surname,
                Age = age,
                Gender = gender,
                Pesel = pesel,
                Email = email,
                Weight = weight,
                Increase = increase
            };

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(user.ToString());
        }

        private static int GetId()
        {
            Random random = new Random();
            return random.Next(1, 10000000);
        }

        private static string GetFirstName()
        {
            Console.WriteLine("Enter your First Name:");
            return Console.ReadLine();
        }

        private static string GetSurname()
        {
            Console.WriteLine("Enter your Surname:");
            return Console.ReadLine();
        }

        private static byte GetAge()
        {
            while (true)
            {
                Console.WriteLine("Enter your Age:");
                bool isByte = byte.TryParse(Console.ReadLine(), out byte age);

                if (isByte)
                    return age;
                else
                    Console.WriteLine("Incorrect Age value.");
            }
        }

        private static Gender GetGender()
        {
            byte genderVal;

            while (true)
            {
                Console.WriteLine("Enter your Gender: 1 - Male, 2 - Female, 3 - Other");
                bool isByte = byte.TryParse(Console.ReadLine(), out genderVal);

                if (isByte && (genderVal > 0 && genderVal < 4))
                    break;
                else
                    Console.WriteLine("Incorrect Gender value.");
            }

            Gender gender = genderVal switch
            {
                1 => Gender.Male,
                2 => Gender.Female,
                3 => Gender.Other
            };

            return gender;
        }

        private static byte[] GetPesel()
        {
            byte[] pesel = new byte[11];

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Enter your {i + 1} pesel digit:");
                bool isByte = byte.TryParse(Console.ReadLine(), out byte digit);

                if (isByte && (digit >= 0 && digit <= 9))
                    pesel[i] = digit;
                else
                {
                    Console.WriteLine("Invalid value");
                    i--;
                }
            }

            return pesel;
        }

        private static string GetEmail()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your Email:");

                    string email = Console.ReadLine();

                    MailAddress mail = new MailAddress(email);

                    return email;
                }
                catch
                {
                    Console.WriteLine("Invalid Email");
                    continue;
                }
            }
        }

        private static float GetWeight()
        {
            while (true)
            {
                Console.WriteLine("Enter your Weight:");
                bool isFloat = float.TryParse(Console.ReadLine(), out float weight);

                if (isFloat && weight > 0)
                    return weight;
                else
                    Console.WriteLine("Incorrect Weight value.");
            }
        }

        private static short GetIncrease()
        {
            while (true)
            {
                Console.WriteLine("Enter your Increase:");
                bool isShort = short.TryParse(Console.ReadLine(), out short increase);

                if (isShort && increase > 0)
                    return increase;
                else
                    Console.WriteLine("Incorrect Weight value.");
            }
        }
    }
}