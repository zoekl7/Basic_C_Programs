using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] nouns = { " movie", " flower", " eggs", " ham", " sky", " phone", " hair", " fruit", " carpet", " ink" };

        Console.WriteLine("Enter your favorite color:");
        string color = Console.ReadLine();

        for (int i = 0; i < nouns.Length; i++)
        {
            nouns[i] = color + nouns[i];
        }

        for (int j = 0; j < nouns.Length; j++)
        {
            Console.WriteLine(nouns[j]);
        }
        Console.ReadLine();


        //for (int i = 0; i > -10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        //for (int i = 0; i > -10; i--)
        //{
        //    Console.WriteLine(i);
        // }
        //Console.ReadLine();

        for (int i = 0; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        List<string> animals = new List<string> { "lion", "elephant", "eagle", "deer", "giraffe", "zebra", "rhino", "hippo", "monkey", "gorilla", "crocodile", "gazelle", "leopard" };
        bool validAnimal = false;
        Console.WriteLine("Welcome to the \"See Sharp\" Safari Tour. Please enter an animal to check if it is on our \"commonly seen animals\" list:");

        while (!validAnimal)
        {
            string userAnimal = Console.ReadLine();
            foreach (string animal in animals)
            {
                if (userAnimal == animal)
                {
                    Console.WriteLine("The animal you selected is on our list! List index: " + animals.IndexOf(animal));
                    validAnimal = true;
                    break;
                }
            }
            if (!validAnimal)
            {
                Console.WriteLine("Sorry, your animal was not found on our list. Please enter another animal.");
            }
        }
        Console.ReadLine();

        List<string> pets = new List<string> { "dog", "cat", "fish", "dog", "fish", "hamster", "bird", "fish", "turtle", "fish", "fish", "bird", "snake", "guinea pig", "cat", "dog" };
        bool validPet = false;
        Console.WriteLine("Welcome to the Petshop! Enter a species to see how many times it appears in the Petshop's inventory of pets:");

        while (!validPet)
        {
            string userPet = Console.ReadLine();
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] == userPet)
                {
                    Console.WriteLine("The Petshop has a " + userPet + "! List index: " + i);
                    validPet = true;
                }
            }
            if (!validPet)
            {
                Console.WriteLine("The Petshop does not have a " + userPet + ". Please try another species.");
            }
        }
        Console.ReadLine();

        List<string> movies = new List<string>() { "Black Panther", "Deadpool", "Princess Bride", "Cry Baby", "Airplane!", "Rocky Horror Picture SHow", "V for Vendetta", "Young Frankenstien", "Pulp Fiction", "Star Wars", "Pirates of the Caribbean", "Harry Potter", "V for Vendetta", "Star Wars", "Lord of the Rings", "Star Wars" };
        List<string> countedMovies = new List<string>();
        Console.WriteLine("Northwest Movie Rental. Current list of movies available: ");

        foreach (string movie in movies)
        {
            Console.WriteLine(movie);
            foreach (string countedMovie in countedMovies)
            {
                if (movie == countedMovie)
                {
                    Console.WriteLine("(at least one copy of this movie counted earlier!)");
                    break;
                }
            }
            countedMovies.Add(movie);
        }
        Console.ReadLine();
    }
}

