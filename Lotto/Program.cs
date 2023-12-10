using System;
using System.Collections.Generic;
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

            minimumKivalasztasosRendezes(lottoSzamok);

            Console.ReadKey();
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

            for (i=0; i<5; i++)
            {
                lotto[i]= rnd.Next(1,90);
               
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
