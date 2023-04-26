using System;

namespace Classes_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings(); //Greetings object
            greetings.Welcome(); //Calls welcome method

            Console.WriteLine("WHat is your name?"); //Asks the user for its name
            string userName = Console.ReadLine(); //Saves the name to a variable called "userName"

            greetings.Hello(userName); //Passes userName as the argument for Hello method
        }
    }
}
