namespace Brackeys_Challenge___3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName;
            string reply;

            Console.WriteLine("Hello, what is your name?");

            userName = Console.ReadLine();

            Console.WriteLine($"{userName}, what a wonderful name can you answer some math questions?");

            reply = Console.ReadLine();

            if(reply == "no")
            {
                if(reply == "yes")
                {
                    Console.WriteLine("Right on let's begin!");
                }
                Console.WriteLine("Oh, well thats too bad you're answering them anyways!");
            }

            Console.Write("what is 2 + 2 = ");
            
            if(Console.ReadLine() == "4")
            {
                Console.WriteLine("Correct");
            }
            else
            { 
                Console.WriteLine("Incorrect, would you like to try again?");
                reply = Console.ReadLine();

                if (reply == "yes")
                {
                    Console.Write("Too bad you fucked up the first time idiot");
                    

                }
                else
                {
                    Console.WriteLine("You're a dumbass goodbye!");
                }

            }
            
            

            

        }
    }
}