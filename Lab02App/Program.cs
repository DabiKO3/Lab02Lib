using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02Lib;

namespace Lab02App
{
     class Program
    {
        static void Main(string[] args)
        {
            Processor[] arrProcessor;
            Console.Write("Веддiть кiлькiсть процесорiв:  ");
            int cntProcessor = int.Parse(Console.ReadLine());
            arrProcessor = new Processor[cntProcessor];

            for (int i = 0; i < cntProcessor; i++)
            {
                Console.WriteLine("Введiть назву процесора: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введiть виробника: ");
                string manufacturer = Console.ReadLine();
                Console.WriteLine("Введiть кiлькiсть ядер: ");
                int cores = int.Parse(Console.ReadLine());
                Console.WriteLine("Введiть частоту процесора (GHz): ");
                double frequency = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть тепловидiлення (TDP в Вт): ");
                double tdp = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть кiлькiсть транзисторiв (млн): ");
                long transistors = long.Parse(Console.ReadLine());
                Console.WriteLine("Чи пiдтримує багатопоточнiсть? (y - так /n - ні ): ");
                ConsoleKeyInfo multithreading = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Введiть продуктивнiсть на 1 ядро (бали): ");
                double performancePerCore = double.Parse(Console.ReadLine());


                Processor myProcessor = new Processor();
                myProcessor.Name = name;
                myProcessor.Manufacturer = manufacturer;
                myProcessor.Cores = cores;
                myProcessor.Frequency = frequency;
                myProcessor.TDP = tdp;
                myProcessor.Transistors = transistors;
                myProcessor.Multithreading = multithreading.Key == ConsoleKey.Y ? true : false;
                myProcessor.PerformancePerCore = performancePerCore;
                arrProcessor[i] = myProcessor;
            }

            foreach (Processor t in arrProcessor)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Данi про процесор:");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Назва: " + cntProcessor);
                Console.WriteLine("Виробник: " + t.Manufacturer);
                Console.WriteLine("Кiлькiсть ядер: " + t.Cores);
                Console.WriteLine("Частота: " + t.Frequency.ToString("0.00") + " GHz");
                Console.WriteLine("Тепловидiлення (TDP): " + t.TDP.ToString("0.00") + " W");
                Console.WriteLine("Багатопоточнiсть: " + (t.Multithreading ? "Так" : "Ні"));
                Console.WriteLine("Продуктивнiсть на 1 ядро: " + t.PerformancePerCore.ToString("0.00") + " бали");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Загальна продуктивнiсть: " + t.yearIncomePerInhabitant.ToString("0.00") + " бали");
            }
            Console.WriteLine();
        }

    }
}
