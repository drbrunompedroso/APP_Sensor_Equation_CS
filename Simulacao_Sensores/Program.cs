using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensoresAPP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetWindowSize(70, 30);
            Console.Title = "APP - Transdução de Sensores";

            while(true)
            {
                Console.WriteLine("******APP PARA TRANSDUÇÃO DE SINAIS DE SENSORES ANALÓGICOS:******");

                try
                {
                    double TransductionVar = Transduction();
                    Console.WriteLine("\nResultado da Transdução: {0} (U.M.)", TransductionVar);
                }
                catch (Exception erro)
                {
                    Console.WriteLine("\nNão é possível solucionar o cálculo com os valores informados ");
                }
                Console.WriteLine("\n******************************************************");
                Console.ReadKey();
                Console.Clear();
            }            
        }
        
        static double Transduction()
        {
            Console.WriteLine("\n******Modelagem do Sensor******* \n");
            Console.WriteLine("\nValor Máximo da Variável de Saída (Ymax): \n");
            double Ymax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nValor Minimo da Variável de Saída (Ymin): \n");
            double Ymin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nValor Máximo da Variável de Entrada (Xmax): \n");
            double Xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nValor Minimo da Variável de Entrada (Xmin): \n");
            double Xmin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSinal o Sensor (V/mA): \n");
            double SignalSensor = Convert.ToDouble(Console.ReadLine());   
            double Result = ((SignalSensor - Ymin) / ((Ymax - Ymin) / (Xmax - Xmin)));
            Result = Math.Round(Result, 2);
            
            return Result;
        }
    }
}