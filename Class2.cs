using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Class2
    {
        /// <summary>
        /// Length - возвращает длину строки
        /// </summary>
        public static void Two()
        {
            Console.WriteLine("Введите две строки:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int length1, length2;
            length1 = str1.Length;
            length2 = str2.Length;
            Console.WriteLine("Длина строки {0}={1}", str1, length1);
            Console.WriteLine("Длина строки {0}={1}", str2, length2);
            Console.ReadKey();
        }
    }
}
