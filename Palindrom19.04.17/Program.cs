using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom19._04._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string slovo = Console.ReadLine();
            int s = 0;
            char[] arra =new char[slovo.Length];

            for (int i = 0; i < slovo.Length; i++)
            {
                arra[i] = slovo[i];
            }

            for (int i = 0; i < slovo.Length/2; i++)
            {
                if (arra[i] == arra[arra.Length - (1+i)])
                {
                    s++;
                }
                else
                {
                    Console.WriteLine("НЕ Полиндром");
                    break;
                }
            }
            if (s== slovo.Length / 2)
                Console.WriteLine("Полиндром");
            Console.ReadKey();
        }
    }
}
