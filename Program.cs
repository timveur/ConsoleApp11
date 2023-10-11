using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            //Создание переменной, которую будет "считывать" switch
            int number = Convert.ToInt32(Console.ReadLine());
            //Оператор switch принимает выражение или переменную и сравнивает его значение со значением каждого case
            switch (number)
            {
                //Когда оператор switch находит подходящее значение, он также выполняет все нижестоящие блоки case.
                //Чтобы этого избежать, нужно использовать оператор break в конце каждого блока case.
                //Оператор break завершает выполнение оператора switch, что предотвращает выполнение несоответствующих case.
                case 1:
                    //Выполнение метода из другого класса
                    Class1.First(); //ИмяКласса.ИмяМетода();
                    break;
                case 2:
                    Class2.Two();
                    break;
                case 3:
                    //Выполнение метода из текущего класса
                    Three(); //ИмяМетода();
                    break;
                case 4:
                    Four();
                    break;
                case 5:
                    Five();
                    break;
                case 6:
                    Six();
                    break;
                //Если ни одно значение case не соответствует выражению,
                //выполняется блок кода внутри оператора default.
                //Оператор default в конце switch аналогичен блоку else в конструкции if-else. 
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }


        //Методы

        /// <summary>
        /// Substring - возвращает подстроку из строки
        /// Имеет два варианта:
        /// 1. Substring(Int32) - Возвращает подстроку начиная с указанной позиции и до конца исходной строки.
        /// 2. Substring(Int32, Int32) - Возвращает подстроку начиная с указанной позиции с заданной длины.
        /// </summary>
        public static void Three()
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            // 2 вариант использования Substring
            string subStr = str.Substring(7, 4);
            Console.WriteLine(subStr);
        }

        /// <summary>
        /// Replace - замена элементов строки
        /// Наиболее часто используемые варианты – это замена символа на символ и строки на подстроку
        /// </summary>
        public static void Four()
        {
            string str = "Visual C# Express C#";
            //Замена "C#" на "Basic"
            string subStr = str.Replace("C#", "Basic");
            Console.WriteLine(subStr);
        }

        /// <summary>
        /// Join - используется для объединения элементов с указанием разделителя
        /// </summary>
        public static void Five()
        {
            //задан массив строк из 3-х элементов
            string[] str = {"qwer","tyu","123456"};
            //в строке st1 элементы массива str будут написаны через запятую
            string st1 = string.Join(",", str);
            Console.WriteLine(st1);
            //в строке st2 элементы массива str будут написаны через пробел
            string st2 = string.Join(" ", str);
            Console.WriteLine(st2);
        }

        /// <summary>
        /// Split and Join
        /// Замена разделителя путем создания из строки массива с подстроками
        /// с помощью деления по разделителю с использованием метода Split,
        /// а затем объединение в одну строку с добавлением нового 
        /// разделителя с помощью метода Join.
        /// </summary>
        public static void Six()
        {
            Console.WriteLine("Введите несколько слов");
            string spl = Console.ReadLine();
            //Деление строки на подстроки по разделителю (пробел)
            string[] resSpl = spl.Split(' ');
            //Объединение всех элементов массива resSpl с добавлением разделителя (запятая и пробел)
            string st = string.Join(", ", resSpl); 
            Console.WriteLine(st);
            
        }
    }
}
