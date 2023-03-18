using System;
//Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
//Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
namespace Modul10Task2
{
    class MainClass
    {
        static ILogger Logger;
        public static void Main(string[] args)
        {
            Logger = new Logger();
            Calculator calc = new Calculator(Logger);
            try
            {
                Console.WriteLine("Выберите операцию\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        calc.Sum();
                        break;
                    case 2:
                        calc.Subtr();
                        break;
                    case 3:
                        calc.Mult();
                        break;
                    case 4:
                        calc.Div();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                calc.ErrorHandler();
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
