using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayApp.Model;

namespace BirthdayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek: ");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twój wiek to: " + age);

            Console.WriteLine();

            Birthday myBirthday = new Birthday();

            myBirthday.DrawCake(age);

            Console.Read();
        }
    }
}
