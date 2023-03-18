//Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
//Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
namespace Modul10Task2
{
    class Calculator : ICalculator
    {
        protected ILogger Logger { get;}
        public Calculator(ILogger logger) 
        {
            Logger = logger;
        }
        public void ErrorHandler() 
        {
            Logger.Error();
        }
        public void Div()
        {
            Logger.Event("Операция деления\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a / b));
        }

        public void Mult()
        {
            Logger.Event("Операция умножения\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a * b));
        }

        public void Subtr()
        {
            Logger.Event("Операция вычитания\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a - b));
        }

        public void Sum()
        {
            Logger.Event("Операция сложения\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a + b));
        }
    }
}
