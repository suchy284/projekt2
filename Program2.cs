using System;

namespace program2TS
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            int[] tablica = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 11, 12, 13, 14 };
            int[] test = new int[15];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write($"{tablica[i]}  ");
            }
            //zad2
            /*Rodzaje tablic:
            1.Tablica jednowymiarowa 
            2.Tablica wielowymiarowa
            3.Tablica jagged 
            To tablice, których elementami są inne tablice, ale różnej długości
            Przykład
            Załóżmy, że mamy dane o ocenach uczniów z różnych przedmiotów. Każdy uczeń może mieć różną liczbę ocen, więc użyjemy jagged array do przechowania tych informacji.
            4.ArrayList
            4.Tablica typu List<T>
            5.Tablica o zmiennym rozmiarze
            */
            //zad3
            Console.WriteLine();
            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"{tablica[i]}  ");
            }
            //zad4
            Console.WriteLine();
            for (int i = 9; i >= 0; i--)
            {
                Console.Write($"{tablica[i]}  ");
            }
            //zad5
            /*otrzymamy IndexOutOfRangeException, czyli wyjątek wskazujący, że odwołaliśmy się do nieistniejącego indeksu.*/
            Console.WriteLine();
            foreach (int number in tablica)
            {

                Console.Write($"{number} ");
            }
            int length = tablica.Length;

            Console.WriteLine($"\nTablica ma długość: {length}");
            
            //zad6

            /*
            Pytanie 1 
            W C# zmienne (elementy) tablicy można przypisać na dwa główne sposoby:

            1 W momencie deklaracji tablicy.
            2 Po zadeklarowaniu tablicy 
            Pytanie 2
            Tak, w C# można przypisać wartości do tablicy już podczas jej deklaracji. Jest to najczęściej stosowany sposób inicjalizacji tablic
            Pytanie3
            Tak, jeżeli tablica została zadeklarowana z wartościami, to wartości te są przypisane i umieszczone w pamięci podczas uruchamiania programu.
            Inicjacja nie jest potrzebna, jeżeli tablica została zadeklarowana z wartościami w momencie deklaracji.
            */
            //zad7
            Console.WriteLine("zad7");
            int[] unsorted = { 5, 6, 7, 8, 12, 14, 15, 44, 3, 0 };
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length; j++)
                {
                    if (unsorted[i] < unsorted[j])
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;

                    }
                }
            }
            for (int i = 0; i<unsorted.Length; i++)
            {
                Console.Write(unsorted[i]+ " , ");

            }
            /*Program zadziala jeżeli bedą dwie te same wartosci 
            Sortowanie bąbelkowe (Bubble Sort) nie jest wydajnym algorytmem. Jego złożoność czasowa to O(n²), co oznacza, że czas działania rośnie kwadratowo w zależności od liczby elementów. Dla dużych zbiorów danych jest bardzo wolne. Chociaż jest łatwe do zrozumienia i implementacji, inne algorytmy, jak QuickSort czy MergeSort (złożoność O(n log n)), są znacznie szybsze i bardziej efektywne.

            Sortowanie bąbelkowe może być użyteczne w małych zbiorach danych, ale dla większych danych lepiej zastosować bardziej zaawansowane algorytmy.
            */
            Console.ReadLine();




        }
    }
}
