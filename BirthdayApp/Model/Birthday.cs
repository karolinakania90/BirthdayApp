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
            if(age >= 18)
            {
                Console.WriteLine("Możesz już pić alkohol!");
                Console.WriteLine();
                star = "%";
                bottomStar = "!";
            }

            for (int i = 0; i < age; i++)
            {
                Console.Write(star);

            }

            Console.WriteLine();

            for (int i = 0; i < age; i++)
            {
                Console.Write(bottomStar);
            }
        }
    }
}
