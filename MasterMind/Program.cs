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
            bool[] corretti = { false, false, false, false };
            Random rd = new Random();
            bool vinto = false, doppione = true;

            Console.WriteLine("Inserire in ordine il codice segreto");
            for (int i = 0; i < 4; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out codice_segreto[i])) {}

                //Controllo dei doppioni non funzionante
                for (int n = 0; n < 4; n++)
                {
                    while (!doppione)
                    {
                        if (codice_segreto[i] == codice_segreto[n])
                        {
                            doppione = true;
                            Console.WriteLine("Il codice segreto non puo prevedere i doppioni");
                            while (!int.TryParse(Console.ReadLine(), out codice_segreto[i])) { }
                        }
                        else
                        {
                            doppione = false;
                        }
                    }
                    
                }
            }
            Console.Clear();

            do
            {
                for (int i = 0; i < 4; i++)
                {
                    //Genera il numero
                    codice_generato[i] = rd.Next(0, 10);

                    //Controllo se il numero in posizione giusta è correta
                    if (codice_generato[i] == codice_segreto[i])
                    {
                        if (corretti[i] == true)
                        {
                            continue;
                        }
                        else
                        {
                            corretti[i] = true;
                            Console.WriteLine($"Il computer ha trovato il numero giusto in posiozione {i + 1}");
                            correto_giusto[i] = codice_segreto[i];
                        }
                    }
                }

                vinto = true;
                //Controllo se tutti i numeri sono corretti
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

            //Stampa dei risultati
            Console.Write("Il computer ha trovato tutti i numeri (i numeri trovati dal pc sono:");
            foreach (var item in correto_giusto)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine(")");

            Console.Write("(I numeri segreti sono:");
            foreach (var item in codice_segreto)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine(")");

            Console.ReadKey();
        }
    }
}
