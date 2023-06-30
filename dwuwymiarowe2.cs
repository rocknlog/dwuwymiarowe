using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int dolnyWiersz = 9;
        int gornyWiersz = 0;
        int lewaKolumna = 0;
        int prawaKolumna = 9;

        while (liczba <= 100)
        {
            for (int i = lewaKolumna; i <= prawaKolumna; i++)
            {
                tablica[gornyWiersz, i] = liczba;
                liczba++;
            }
            gornyWiersz++;

            for (int i = gornyWiersz; i <= dolnyWiersz; i++)
            {
                tablica[i, prawaKolumna] = liczba;
                liczba++;
            }
            prawaKolumna--;

            for (int i = prawaKolumna; i >= lewaKolumna; i--)
            {
                tablica[dolnyWiersz, i] = liczba;
                liczba++;
            }
            dolnyWiersz--;

            for (int i = dolnyWiersz; i >= gornyWiersz; i--)
            {
                tablica[i, lewaKolumna] = liczba;
                liczba++;
            }
            lewaKolumna++;
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


