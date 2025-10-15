namespace EgzaminProbnyKonsolowka
{
    internal class Program
    {
        static int N = 50;
        static int[] tablica = new int[N];
        static Random rand = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < N; i++)
            {
                tablica[i] = rand.Next(0, 101);
            }

            Console.Write("Tablica nieposortowana: ");
            foreach(var item in tablica)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nTablica posortowana: ");
            foreach (var item in sortuj(tablica))
            {
                Console.Write(item + " ");
            }

        }

        //**************************
        //nazwa funkcji: sortuj
        //opis funkcji: sortuje tablice od najwiekszego do najmniejszego używając sortowania przez wybieranie
        //parametry: tablica - tablica do posortowania
        //zwracany typ i opis: int[] - tablica posortowana
        //autor: Paweł
        //**************************
        static int[] sortuj(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                int najwieksza = znajdzNajwieksza(tablica, i);
                int temp = tablica[i];
                tablica[i] = tablica[najwieksza];
                tablica[najwieksza] = temp;

            }

            return tablica;
        }

        //**************************
        //nazwa funkcji: znajdzNajwieksza
        //opis funkcji: znajduje najwieksza wartosc w tablicy od podanego indexu do konca tablicy
        //parametry: tablica - tablica do znalezienia najwiekszej wartości
        //           index - index od ktorego zaczynamy szukac najwiekszej wartosci
        //zwracany typ i opis: int - index gdzie znajduje się najwieksza wartość
        //autor: Paweł
        //**************************
        static private int znajdzNajwieksza(int[] tablica, int index)
        {
            int maxWartosc = tablica[index];            
            int indexNajwiekszy = index;
            for (int i = index; i < tablica.Length; i++)
            {
                if (tablica[i] > maxWartosc)
                {
                    maxWartosc = tablica[i];
                    indexNajwiekszy = i;
                }
            }
            return indexNajwiekszy;
        }
    }
}
