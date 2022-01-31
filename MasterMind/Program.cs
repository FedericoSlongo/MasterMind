using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codice_segreto = new int[4], codice_generato = new int[4], correto_giusto = new int[4];
            Random rd = new Random();
            bool vinto = false;

            Console.WriteLine("Inserire in ordine il codice segreto");
            for (int i = 0; i < 4; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out codice_segreto[i])) {}
                for (int n = 0; n < 4; n++)
                {
                    if (i==n)
                    {
                        continue;
                    }
                    else
                    {
                        if (codice_segreto[i] == codice_segreto[n])
                        {
                            Console.WriteLine("Il codice segreto non puo prevedere i doppioni");
                            while (!int.TryParse(Console.ReadLine(), out codice_segreto[i])) { }
                        }
                    }
                }
            }
            Console.Clear();

            do
            {
                for (int i = 0; i < 4; i++)
                {
                    codice_generato[i] = rd.Next(0, 10);
                    if (codice_generato[i] == codice_segreto[i])
                    {
                        Console.WriteLine($"Il computer ha trovato il numero giusto in posiozione {i+1}");
                        correto_giusto[i] = codice_segreto[i];
                    }
                }

                vinto = true;
                for (int i = 0; i < 4; i++)
                {
                    if (correto_giusto[i] == codice_segreto[i])
                    {
                    }
                    else
                    {
                        vinto = false;
                    }
                }

            } while (!vinto);

            Console.WriteLine("Il computer ha trovato tutti i numeri");

            Console.ReadKey();
        }
    }
}
