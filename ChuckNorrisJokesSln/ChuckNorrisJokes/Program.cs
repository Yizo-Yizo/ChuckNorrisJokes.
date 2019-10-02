using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();

            string randomJokeString = await jokeGenerator.GetRandomJoke();

            Console.WriteLine(randomJokeString);


        //    JokeGenerator JokeGenerator = new JokeGenerator();

         //   string[] categories = await JokeGenerator.GetCategories();

        //    for (int index = 15; index > categories.Length; index--) 
         //   {
         //       return(categories[index]);
        //    }
            
        }
    }
}
