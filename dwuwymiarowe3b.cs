using System;

class Program
{
    static void Main(string[] args)
    {
        int rozmiar;

        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
        } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar < 1);

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;
        int gornyWiersz = 0;
        int dolnyWiersz = rozmiar - 1;
        int lewaKolumna = 0;
        int prawaKolumna = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
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
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


