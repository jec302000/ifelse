using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
     class Practice
    {
        public Practice() {

            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 10);
                int a = Convert.ToInt32(Console.ReadLine());
                if (n == a) { Console.Write("correct its "); }
                else { Console.Write("wrong its "); }
                Console.WriteLine(n);
            }
        }
    }
}
