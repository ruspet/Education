using System; //включение пространства имен
using System.Collections.Generic; //включение пространства имен
using System.Linq; //включение пространства имен
using System.Text; //включение пространства имен
using System.Threading.Tasks; //включение пространства имен

namespace Example_1 //пространство имен Example_1
{
    class Program //класс Program
    {
        static void Main(string[] args) //главная функция(точка входа в программу)
        {
            Console.WriteLine("Hello, world!"); //вывод строки
            Console.ReadLine(); //ожидание нажатия клавиши
            string name;
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            string secondName;
            Console.WriteLine("Введите фамилию: ");
            secondName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Здравствуй, { name} { secondName}!");

            string sAge;
            byte age;
            Console.WriteLine("Введите возраст: ");
            sAge = Console.ReadLine();
            if (byte.TryParse(sAge, out age))
            {
                if (age < 18)
                {
                    Console.WriteLine("Несовершеннолетний");
                }
                else if (age > 100)
                    Console.WriteLine("Столько не живут");
                else
                    Console.WriteLine("Совершеннолетний");
            }
            else
                Console.WriteLine("Ошибка ввода");
            Console.ReadLine();

        }
    }
}
