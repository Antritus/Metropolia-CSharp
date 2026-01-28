using System;
using System.Collections.Generic;

internal class T9_3
{
    public static void Run(string[] args)
    {
        T9_3 t9_3 = new T9_3();
        t9_3.start();
    }

    private List<T9_3Leffa> movies = new List<T9_3Leffa>();

    public void start()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Leffojen Katseluloki");
            Console.WriteLine("====================");
            Console.WriteLine("1) Lisää Leffa");
            Console.WriteLine("2) Poista Leffa");
            Console.WriteLine("3) Näytä Raportti");
            Console.WriteLine("4) Lataa Tietokanta");
            Console.WriteLine("5) Tallenna Tietokanta");
            Console.WriteLine("6) Lopeta");
            Console.Write("Syöte: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (input)
            {
                case 1:
                    addMovie();
                    break;
                case 2:
                    removeMovie();
                    break;
                case 3:
                    showMovies();
                    break;
                case 4:
                    downloadDatabase();
                    break;
                case 5:
                    saveDatabase();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Tuntematon komento");
                    break;
            }
        }
    }

    public void addMovie()
    {
        Console.WriteLine("Lisää Leffa:");
        Console.Write("Nimi:");
        string name = Console.ReadLine();
        Console.Write("Kesto (min):");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Vuosi:");
        int year = int.Parse(Console.ReadLine());

        movies.Add(new T9_3Leffa(name, length, year));
    }
    
    public void removeMovie()
    {
        Console.WriteLine("Poista Leffa");
    }


    public void showMovies()
    {
        int totalMovies = 0;
        int totalMinutes = 0;
        foreach (var movie in movies)
        {
            Console.WriteLine($"{movie.name} ({movie.released}), {movie.length} minuuttia.  ");
            totalMinutes += movie.length;
            totalMovies++;
        }

        Console.WriteLine();
        Console.WriteLine($"Leffoja katsottu yhteensä {totalMovies}, yhteiskesto {totalMinutes} minuuttia.");
    }
    
    public void downloadDatabase()
    {
        Console.WriteLine("Lataa Tietokanta");
    }

    public void saveDatabase()
    {
        Console.WriteLine("Tallenna Tietokanta");
    }
}

[Serializable]
class T9_3Leffa
{
    public string name;
    public int length;
    public int released;

    public T9_3Leffa(string name, int length, int released)
    {
        this.name = name;
        this.length = length;
        this.released = released;
    }
}