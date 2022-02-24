using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Comp_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Версия вашей ОС: {0}", Environment.OSVersion);
            Console.WriteLine("Эта ОС 64-х битная? {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            Console.WriteLine("Имя компьюера: {0}", Environment.MachineName);
            Console.WriteLine("Логические диски: {0}", String.Join(", ", Environment.GetLogicalDrives())); //.TrimEnd(',', ' ').Replace("\\", String.Empty));
            Console.WriteLine("Количество процессоров: {0}", Environment.ProcessorCount);
            Console.WriteLine("Системная папка: {0}", Environment.SystemDirectory);
            
            Console.ReadLine();
        }
    }
}
