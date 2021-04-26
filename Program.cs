using System;

namespace kalkulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przywitanie
            Console.WriteLine("Witaj w kalkulatorze!");
            Console.WriteLine("Naciśnij dowolny przycisk, aby kontynuować.");
            Console.ReadLine();

            //Wybór liczby pierwszej
            Console.WriteLine("Wybierz pierwszą liczbę");
            int pierwszaLiczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybrano liczbę: " + pierwszaLiczba);
            Console.WriteLine();

            //Wybór liczby drugiej
            Console.WriteLine("Wybierz drugą liczbę");
            int drugaLiczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybrano liczbę: " + drugaLiczba);
            Console.WriteLine();

            //Wybór działania
            Console.WriteLine("Wybierz działanie:");

            Console.WriteLine("Dodawanie");
            Console.WriteLine("Odejmowanie");
            Console.WriteLine("Mnożenie");
            Console.WriteLine("Dzielenie");

            //Działania
            int dodawanie = pierwszaLiczba + drugaLiczba;

            int odejmowanie = pierwszaLiczba - drugaLiczba;

            int mnożenie = pierwszaLiczba * drugaLiczba;

            int dzielenie = pierwszaLiczba / drugaLiczba;

            //Wprowadzenie do systemu działania
            Console.WriteLine();
            Console.WriteLine("Wybierz działanie: ");
            string wybraneDziałanie = Console.ReadLine();



            //Wykonanie oraz wyświetlanie wszystkich danych
            switch (wybraneDziałanie)
            {
                //dodawanie
                case "Dodawanie":
                        Console.WriteLine();
                        Console.WriteLine("Pierwsza liczba to: " + pierwszaLiczba);
                        Console.WriteLine();
                        Console.WriteLine("Druga liczba to: " + drugaLiczba);
                        Console.WriteLine();
                        Console.WriteLine("Wybrane działanie to: " + wybraneDziałanie);
                        Console.WriteLine();
                        Console.WriteLine("Wynik to: " + dodawanie);
                break;

                //odejmowanie
                case "Odejmowanie":
                    Console.WriteLine();
                    Console.WriteLine("Pierwsza liczba to: " + pierwszaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Druga liczba to: " + drugaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Wybrane działanie to: " + wybraneDziałanie);
                    Console.WriteLine();
                    Console.WriteLine("Wynik to: " + odejmowanie);
                break;

                //mnożenie
                case "Mnożenie":
                    Console.WriteLine();
                    Console.WriteLine("Pierwsza liczba to: " + pierwszaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Druga liczba to: " + drugaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Wybrane działanie to: " + wybraneDziałanie);
                    Console.WriteLine();
                    Console.WriteLine("Wynik to: " + mnożenie);
                break;

                //dzielenie
                case "Dzielenie":
                    Console.WriteLine();
                    Console.WriteLine("Pierwsza liczba to: " + pierwszaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Druga liczba to: " + drugaLiczba);
                    Console.WriteLine();
                    Console.WriteLine("Wybrane działanie to: " + wybraneDziałanie);
                    Console.WriteLine();
                    Console.WriteLine("Wynik to: " + dzielenie);
                break;
            }

            //Podziękowanie
            Console.WriteLine();
            Console.WriteLine("Nacisnij dowolny przycisk, aby zakończyć");
            Console.ReadLine();

            Console.WriteLine("Autor: Dominik Borzyszkowski");
            Console.WriteLine("Dziękuję za skorzystanie z kalkulatora!");
        }
    }
}
