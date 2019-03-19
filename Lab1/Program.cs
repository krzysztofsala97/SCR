using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Roszyk_Sala
{
    class Metody
    {
        int N1 = 10;
        int N2 = 1010;
        public void Losuj(double[] tablica)
        /* metoda wpisująca do tablicy losowe liczby */
        {
            Random losowa = new Random();
            for (int i = 0; i < (N2 - N1); i++)
            {
                /*Liczby całkowite*/
                //tablica[i] = losowa.Next(N1, N2);
                /*Liczby wymierne*/
                tablica[i] = losowa.NextDouble() * (N2 - N1) + N1;
            }
        }
        //metoda wypisująca wartości tablicy w jednej lini oddzielone  przez |
        public void Wypisz(double[] tablica)
        {
            for (int i = 0; i < (N2 - N1); i++)
            {
                Console.Write("({0}) ", tablica[i]);
            }
        }
        //metoda przepisująca tablica1 do tablica2 a następnie sortuje tablica2 rosnąco
        public void Sortuj(double[] tablica1, double[] tablica2)
        {
            for (int i = 0; i < (N2 - N1); i++)
            {
                tablica2[i] = tablica1[i];
            }
            Array.Sort(tablica2);
        }
        //metoda wyliczająca pole kwadratu opisanego na kole którego promień to wartość z tablica1 i wpisująca do tablica2
        public void Pole_Opisane(double[] tablica1, double[] tablica2)
        {
            for (int i = 0; i < (N2 - N1); i++)
            {
                tablica2[i] = 4 * Math.Pow(tablica1[i], 2);
            }
        }
        //metoda wyliczająca pole kwadratu wpisanego na kole którego promień to wartość z tablica1 i wpisująca do tablica2
        public void Pole_Wpisane(double[] tablica1, double[] tablica2)
        {
            for (int i = 0; i < (N2 - N1); i++)
            {
                tablica2[i] = 2 * Math.Pow(tablica1[i], 2);
            }
        }
        //metoda wyliczająca różnice między polem wpisanym a opisanym i zapisanie do tablica3
        public void Różnica(double[] tablica1, double[] tablica2, double[] tablica3)
        {
            for (int i = 0; i < (N2 - N1); i++)
            {
                tablica3[i] = tablica1[i] - tablica2[i];
            }
        }
        //metoda zapisująca do tablica3 i wypisująca pary liczb po osiem w lini
        public void Pary(double[] tablica1, double[] tablica2, double[,] tablica3)
        {
            //zapisywanie do tablica3 wartości z tablica1 oraz tablica2
            for (int i = 0; i < 1000; i++)
            {
                tablica3[i, 0] = Math.Round(tablica1[i], 4);
                tablica3[i, 1] = Math.Round(tablica2[i], 4);
            }
            //wypisanie wartości tablica3 po 8 elementów w wierszach
            for (int i = 0; i < 1000; i++)
            {
                if (i % 4 == 3)
                {
                    Console.Write("({0}|{1})\n ", tablica3[i, 0], tablica3[i, 1]);
                }
                else
                {
                    Console.Write("({0}|{1})", tablica3[i, 0], tablica3[i, 1]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Metody funkcje = new Metody();
            double[] tab = new double[1000];
            double[] tab_s = new double[1000];
            double[] tab_ko = new double[1000];
            double[] tab_kw = new double[1000];
            double[] tab_r = new double[1000];
            double[,] tab_a = new double[1000, 2];
            string[] czas = new string[6];
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            funkcje.Losuj(tab);
            stopWatch.Stop();
            czas[0] = stopWatch.ElapsedMilliseconds.ToString();
           //Console.WriteLine("Czas wykonywania funkcji Losuj to:{0}ms",czas[0]);

            stopWatch.Start();
            funkcje.Sortuj(tab, tab_s);
            stopWatch.Stop();
            czas[1] = stopWatch.ElapsedMilliseconds.ToString();
            //Console.WriteLine("Czas wykonywania funkcji Sortuj to:{0}ms", czas[1]);

            stopWatch.Start();
            funkcje.Pole_Opisane(tab, tab_ko);
            stopWatch.Stop();
            czas[2] = stopWatch.ElapsedMilliseconds.ToString();
            //Console.WriteLine("Czas wykonywania funkcji Pole_Opisane to:{0}ms", czas[2]);

            stopWatch.Start();
            funkcje.Pole_Wpisane(tab, tab_kw);
            stopWatch.Stop();
            czas[3] = stopWatch.ElapsedMilliseconds.ToString();
            //Console.WriteLine("Czas wykonywania funkcji Pole_Wpisane to:{0}ms", czas[3]);

            stopWatch.Start();
            funkcje.Różnica(tab_ko, tab_kw, tab_r);
            stopWatch.Stop();
            czas[4] = stopWatch.ElapsedMilliseconds.ToString();
            //Console.WriteLine("Czas wykonywania funkcji Różnica to:{0}ms", czas[4]);

            stopWatch.Start();
            funkcje.Pary(tab, tab_r, tab_a);
            stopWatch.Stop();
            czas[5] = stopWatch.ElapsedMilliseconds.ToString();
            //Console.WriteLine("Czas wykonywania funkcji Pary to:{0}ms", czas[5]);

            Console.WriteLine("\n Czasy wykonywania funkcji: 1. {0}ms, 2. {1}ms, 3. {2}ms, 4. {3}ms, 5. {4}ms, 6. {5}ms,",czas[0], czas[1], czas[2], czas[3], czas[4], czas[5]);
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
