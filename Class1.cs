using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Class1
    {
        /// <summary>
        /// Split - разделяет заданную строку на подстроки, 
        /// в качестве разделителя используется указанный через параметр символ (или группа символов)
        /// Тернарный оператор - аналог условной конструкции if...else. Работает с тремя операторами.
        /// </summary>
        public static void First()
        {
            Console.WriteLine("Введите 2 числа через пробел");
            string spl = Console.ReadLine();
            //Деление строки spl на подстроки. resSpl - массив из подстрок
            string[] resSpl = spl.Split(' ');
            //num1 - число, полученное из массива строк resSpl по индексу 0
            int num1 = Convert.ToInt32(resSpl[0]);
            //num2 - число, полученное из массива строк resSpl по индексу 1
            int num2 = Convert.ToInt32(resSpl[1]);
            //Конструкция if выполняет блок кода, если заданное условие — истинно, т. е. true
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше {num2}");
            }
            //Условие ? Выражение1 : Выражение2;
            //Если Условие = true, оператор возвращает Выражение1.
            //Если Условие = false, оператор возвращает Выражение2
            int result = (num1 > num2) ? (num1+num2) : (num2-num1);
            string res = (num1 > num2) ? "Первое число больше второго" : "Второе число больше первого";
            Console.WriteLine(result); 
            Console.WriteLine(res); 
            Console.ReadKey();





        }

    }
}
