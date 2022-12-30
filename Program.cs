using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("S = Segundo -> 10s = 10 segundos");
                Console.WriteLine("M = Minuto -> 1m = 60 segundos");
                Console.WriteLine("00 = Sair");
                Console.WriteLine("Tempo:");
                System.Console.Write("> ");
                var data = Console.ReadLine().ToLower();

                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                switch (type)
                {
                    case 's':
                        Start(0, time);
                        break;
                    case 'm':
                        Start(0, time * 60);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Opção selecionado invalida");
                        Thread.Sleep(1000);
                        Main();
                        break;
                }
            }
            catch
            {
                System.Console.WriteLine("Erro na opção escolhida, tente novamento!");
                Thread.Sleep(1000);
                Main();
            }

        }
        static void Start(int start_time, int final_time)
        {
            while (start_time != final_time)
            {
                Console.Clear();
                start_time++;
                System.Console.WriteLine(start_time);
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);

            Console.Clear();
            System.Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2000);
            Main();
        }
    }
}