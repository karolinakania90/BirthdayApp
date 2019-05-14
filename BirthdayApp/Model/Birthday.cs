using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Model
{
    public class Birthday
    {
       

        string star = "*";

        string bottomStar = "|";


        public void DrawCake(int age)
        {
            for (int i = 0; i < age; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();

            for (int i = 0; i < age; i++)
            {
                Console.Write("|");
            }
        }
    }
}
