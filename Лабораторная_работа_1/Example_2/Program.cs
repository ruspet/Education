using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textMenu;
            int res;
            
            DateTime d;
            textMenu = @" Выберите действие: 
            1 - Вывести текущую дату;
            2 - Вывести текущее время;
            3 - Выход из программы";
            d = DateTime.Now;            
            
                Console.Clear();
                Console.WriteLine(textMenu);
                res = Convert.ToInt32(Console.ReadLine());

                switch (res)
                {
                    case 1:
                        {
                            Console.WriteLine("Сегодня: {0}", d.ToShortDateString());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Сейчас: {0}", d.ToShortTimeString());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Выход из программы");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода"); break;
                        }                   
                }
                 Console.WriteLine();
            
        }
    }
}
