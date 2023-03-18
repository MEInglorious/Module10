//Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
//Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
namespace Modul10Task2
{
    class Logger : ILogger
    {
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка!!!");
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}
