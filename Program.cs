using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealOneThisTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number plz");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new number plz");
            int n2 = Convert.ToInt32(Console.ReadLine());

            //int n1 = Convert.ToInt32(args[0]);
            //int n2 = Convert.ToInt32(args[1]);

            double percentage = (1/ Convert.ToDouble((n2 - (n1)))*100);
            double percentageDone = 0.00;

           
            List<int> Primes = new List<int>();
            for (int j = n1; j <= n2; j++)
            {
                int i, m = 0, flag = 0;
                m = j / 2;
                for (i = 2; i <= m; i++)
                {
                    if (j % i == 0)
                    {
                        
                        flag = 1;
                        break;
                    }
                }


                if (flag == 0)
                {
                    Primes.Add(j);
                }
                
                Console.Write($"\r{Math.Round(percentageDone, 2)} % is done                 ");
                System.Threading.Thread.Sleep(10);
                percentageDone += percentage;

            }

            Console.WriteLine($"\n\nThere were {Primes.Count} prime numbers in the list.");
            Console.WriteLine("Do you want to see all the prime numbers??");
           
            if (Console.ReadLine().Equals("y"))
            {
                for (int i = 0; i< Primes.Count; i++)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine(Primes[i]);
                    }
                    else
                    {
                        Console.Write(Primes[i] + ", ");
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
