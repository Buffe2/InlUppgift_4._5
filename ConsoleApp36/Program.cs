using System;
namespace InlUppgift_4._5
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Skriv in ett heltal, hur stort som helst");
            string tal = Console.ReadLine();

            for(int i = 0; i < tal.Length; i++)
            {
                string tal2 = tal[i].ToString();
                int siffra = Convert.ToInt32(tal2);

                if (siffra == 9)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(siffra+1);
                    
            }
        
        }

    }

}

