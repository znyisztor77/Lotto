using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random rnd = new Random();

            //int[] lotto= new int[5];
            int[] lottoSzamok;
            lottoSzamok = lottoGeneral();

            lottoSzamokKiir(lottoSzamok);

            tombEllenorzes(lottoSzamok);

            minimumKivalasztasosRendezes(lottoSzamok);

            Console.ReadKey();
        }

        private static void tombEllenorzes(int[] lottoSzamok)
        {
            int i = 0;
            int keres = lottoSzamok[0];
            bool logic = false;

            while(i<lottoSzamok.Length-1 && !logic)
            {
                i++;
                if(keres == lottoSzamok[i])
                {                  
                    logic = true;                                  
                }
                else
                {
                    keres = lottoSzamok[i];
                }

                if (logic)
                {
                    Console.WriteLine("Duplikálódás");
                }
                else
                {
                    Console.WriteLine("Ok!");
                }
            }
        }

        private static void lottoSzamokKiir(int[] lottoSzamok)
        {
            int i;
            for(i=0; i<lottoSzamok.Length; i++)
            {
                Console.Write(lottoSzamok[i]+", ");
            }
        }

        public static int[] lottoGeneral()
        {
            Random rnd = new Random();
            int i;
            int[] lotto = new int[5];
            
            for (i=0; i<lotto.Length; i++)
            {
               lotto[i] = rnd.Next(1, 91);               
            }
            
            return lotto;
        }

        public static void minimumKivalasztasosRendezes(int[] tomb)
        {
            int n = tomb.Length; 
            int csere;
            int min;

            for (int i = 0; i < n; i++)
            {
                 min = i;
                 for (int j = i+1; j < n; j++)
                 {
                    if(tomb[min] > tomb[j])
                    {
                        min = j;
                    }
                  }
            csere = tomb[i];
            tomb[i] = tomb[min];
            tomb[min] = csere;

            }

            Console.WriteLine();
            for (int k = 0; k < n; k++)
            { 
                Console.Write(tomb[k] + ", ");
            }
                    
        }   
    }
}
