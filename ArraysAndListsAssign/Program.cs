using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // array of strings
        string[] RandomMovies = new string[] { "Star Wars", "V for Vendetta", "Lord of the Rings", "Pulp Fiction", "Pirates of the Caribbean" };
        Console.WriteLine("Random Movies to Watch! Enter an integer between 0 and 4 inclusive.");
        int userChoice1 = Convert.ToInt32(Console.ReadLine());
        while (userChoice1 >= RandomMovies.Length || userChoice1 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice1 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(RandomMovies[userChoice1]);
        Console.WriteLine("(Press enter to continue.)");
        Console.ReadLine();

        // array of integers
        int[] intArray = new int[] { 7, 13, 21, 42, 88 };
        Console.WriteLine("Lucky numbers! Enter an integer between 0 and 4 inclusive.");
        int userChoice2 = Convert.ToInt32(Console.ReadLine());
        while (userChoice2 >= intArray.Length || userChoice2 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(intArray[userChoice2]);
        Console.WriteLine("(Press enter to continue.)");
        Console.ReadLine();

        // list of strings
        List<string> RandomVideoGames = new List<string>();
        RandomVideoGames.Add("MarioKart");
        RandomVideoGames.Add("Skyrim");
        RandomVideoGames.Add("Fable II");
        RandomVideoGames.Add("Path of Exile");
        RandomVideoGames.Add("Candy Crush");
        Console.WriteLine("Random games! Enter an integer between 0 and 4 inclusive.");
        int userChoice3 = Convert.ToInt32(Console.ReadLine());
        while (userChoice3 >= RandomVideoGames.Count || userChoice3 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice3 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(RandomVideoGames[userChoice3]);
        Console.Read();
    }
}
