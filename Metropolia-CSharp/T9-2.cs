using System;

internal class T9_2
{
    public static void Run(string[] args)
    {
        T9_2 t9_2 = new T9_2();
        t9_2.start();
    }
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
        Console.WriteLine("Lisää Leffa");
    }

    public void removeMovie()
    {
        Console.WriteLine("Poista Leffa");
    }

    public void showMovies()
    {
        Console.WriteLine("Näytä Raportti");
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