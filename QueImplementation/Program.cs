using System;

namespace QueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (input.ToLower() != "q")
                {
                    if (input.Split(" ")[0].ToLower() == "add")
                    {
                        queue.Add(Convert.ToInt32(input.Split(" ")[1]));
                        Console.WriteLine("added value");
                    }
                    else if (input.Split(" ")[0].ToLower() == "remove")
                    {
                        Console.WriteLine(queue.Remove());
                    }
                    else Console.WriteLine("invalid command");
                    Console.WriteLine("\n");
                }
            } while (input.ToLower() != "q");
        }
    }
}
