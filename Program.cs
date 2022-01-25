using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            int broj = 5;
            string nesto = "C# i .NET";
            for (int i = 0; i < 101; i++)
            {
                lista.Add(i);
            }

            lista.Add(broj);
            lista.Add(nesto);

            Console.WriteLine("Broj elemenata liste: " + lista.Count);
            Console.WriteLine("Ispis svih elemenata prije insert-a");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br. " + i);
                Console.WriteLine(lista[i]);

            }
            lista.Insert(1, "Programiranje");
            Console.WriteLine(Environment.NewLine +
            "Ispis svih elemenata nakon Insert-a");

            Console.WriteLine("Broj elemenata liste: " + lista.Count);
            Console.WriteLine("Ispis svih elemenata poslije insert-a");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br. " + i);
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine(Environment.NewLine +
            "Ispis elemenata koji sadrže C#");

            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == "Programiranje")
                {
                    Console.WriteLine(lista[i]);
                    Console.WriteLine("Broj: " + Environment.NewLine);
                }

                try
                {
                    if (Convert.ToInt32(lista[i]) == 5)
                    {
                        Console.WriteLine(lista[i]);
                        Console.WriteLine("Broj: " + i + Environment.NewLine);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);  
                }
            
            if(lista.Contains(5))
            {
                lista.Remove(5);
            }
            Console.ReadKey();



        }
    }
}
