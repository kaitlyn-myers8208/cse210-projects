using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random(); 
        int randScripture = rnd.Next(1,3);

        Reference reference1 = new Reference("Matthew", "3", "11");
        Reference reference2 = new Reference("John", "8", "11", "12");

        Scripture scripture1 = new Scripture("I indeed baptize you with water unto repentance: but he that cometh after me is mightier than I, whose shoes I am not worthy to bear: he shall baptize you with the Holy Ghost, and with fire:", reference1);
        Scripture scripture2 = new Scripture("She said, No man, Lord. And Jesus said unto her, Neither do I condemn thee: go, and sin no more. Then spake Jesus again unto them, saying, I am the light of the world: he that followeth me shall not walk in darkness, but shall have the light of life.", reference2);

        Console.Clear();
        if (randScripture == 1)
        {
            scripture1.ConvertToList();
            scripture1.DisplayScripture();
        }
        else if (randScripture == 2)
        {
            scripture2.ConvertToList();
            scripture2.DisplayScripture();
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string userResponse = Console.ReadLine();

        // while (userResponse.Length == 0 && (scripture1.count < scripture1.numElements || scripture2.count < scripture2.numElements))
        while (userResponse.Length == 0)
        {
            if (randScripture == 1)
            {
                if (scripture1.count >= scripture1.numElements)
                {
                    return;
                }
                Console.Clear();
                scripture1.HideWords();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                userResponse = Console.ReadLine();
                // Console.Clear();
            }
            else if (randScripture == 2)
            {
                if (scripture2.count >= scripture2.numElements)
                {
                    return;
                }
                Console.Clear();
                scripture2.HideWords();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                userResponse = Console.ReadLine();
                // Console.Clear();
            }      
            // Console.Clear();          
        }

        if (userResponse == "quit")
        {
            return;
        }
        else
        {
            Console.WriteLine("Error: incorrect input");
        }
    }
}