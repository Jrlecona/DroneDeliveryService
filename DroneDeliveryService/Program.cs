using System;

namespace DroneDeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            bool confirmed = false;
            Console.WriteLine("Please introduce the Drone list and each Max Weight:");

            do
            {

                Console.Write("Please enter Drone Name: ");
                Key = Console.ReadLine();

                ConsoleKey response;
                do
                {
                    Console.Write("Are you sure you want to choose this as your login key? [y/n] ");
                    response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                    if (response != ConsoleKey.Enter)
                        Console.WriteLine();

                } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                confirmed = response == ConsoleKey.Y;
            } while (!confirmed);


        }
    }
}
