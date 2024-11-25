using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQualityLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Неиспользуемые переменные и неправильное именование
            int n = 100;
            int i = 0;
            string s = "This is a string";

            // 2. Деление на ноль
            int result = n / i;

            // 3. Логическая ошибка, несоответствие ожиданий
            if (n = 100)  // Ошибка: присваивание вместо сравнения
            {
                Console.WriteLine("The value of n is 100.");
            }

            // 4. Несоответствие стандартам именования переменных
            int firstvalue = 10;
            int secondvalue = 20;

            // 5. Дублирование кода
            Console.WriteLine(firstvalue + secondvalue);
            Console.WriteLine(firstvalue + secondvalue);

            // 6. Большие блоки кода без комментариев
            for (int x = 0; x < 10; x++)
            {
                int y = x * 2;
                if (y > 5)
                {
                    Console.WriteLine("y is greater than 5");
                }
                else
                {
                    Console.WriteLine("y is not greater than 5");
                }
            }

            // 7. Неоправданное использование магических чисел
            double area = 3.14159 * 7 * 7;  // Магическое число "7" (радиус)
            Console.WriteLine($"Area: {area}");
        }
    }
}
