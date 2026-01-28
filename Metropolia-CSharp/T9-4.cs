using System;

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

internal class T9_4
{
    public static void Run(string[] args)
    {
        T9_4 t9_4 = new T9_4();
        t9_4.start();
    }

    private List<T9_4Leffa> movies = new List<T9_4Leffa>();

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

        movies.Add(new T9_4Leffa(name, length, year));
    }

    public void removeMovie()
    {
        Console.WriteLine("Poista Leffa:");
        int totalMovies = 0;
        int totalMinutes = 0;
        foreach (var movie in movies)
        {
            Console.WriteLine($"{totalMovies + 1}) {movie.name} ({movie.released}), {movie.length} minuuttia.  ");
            totalMinutes += movie.length;
            totalMovies++;
        }

        Console.Write("Syöte: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index < 0 || movies.Count < index)
        {
            Console.WriteLine("Syöte ei ole kelvollinen.");
        }
        else
        {
            movies.RemoveAt(index);
        }
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
        string file = "tietokanta.xml";

        var serializer = new XmlSerializer(typeof(List<T9_4Leffa>));

        var settings = new XmlWriterSettings
        {
            Encoding = new UTF8Encoding(false),
            Indent = true
        };

        using (var writer = XmlWriter.Create(file, settings))
        {
            serializer.Serialize(writer, movies);
        }

        Console.WriteLine("Tietokanta tallennettu.");
    }
}

[Serializable]
public class T9_4Leffa
{
    public string name;
    public int length;
    public int released;

    public T9_4Leffa()
    {
    }

    public T9_4Leffa(string name, int length, int released)
    {
        this.name = name;
        this.length = length;
        this.released = released;
    }
}