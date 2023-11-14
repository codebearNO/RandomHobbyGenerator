namespace RandomHobbyGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            for (int i = 0; i < 5; i++ ) 
            {
                int randomNumber = rand.Next(0, 5);
                Console.Write("Who would like a new hobby?! ");
                string name = Console.ReadLine();


                if (randomNumber == 0)
                {
                    Console.WriteLine($"{name} is now a magician. Poof, magic!");
                }
                else if (randomNumber == 1)
                {
                    Console.WriteLine($"{name} is now a diddler. Poof, pedophilia!");
                }
                else if (randomNumber == 2)
                {
                    Console.WriteLine($"{name} is now a fiddler. floof, music!");
                }
                else if (randomNumber == 3)
                {
                    Console.WriteLine($"{name} is now a shidder. Poop!");
                }
                else if (randomNumber == 4)
                {
                    Console.WriteLine($"{name} is now a coomer. Poof, corn!");
                }
            }

        }
    }
}