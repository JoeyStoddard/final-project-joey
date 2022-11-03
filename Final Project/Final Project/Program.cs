using System;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main(string[] args)
    {
        int room = 1;
        string response = "";
        bool gameFinished = false;
        bool key1 = false;
        bool key2 = false;
        bool key3 = false;
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
       




        /*   Console.WriteLine("pick a character dog, cat, car, truck or motorcycle type answers in all lowercase");
           response = Console.ReadLine();
           if (response.Equals("dog"))
           {
               Console.WriteLine("You chose the Dog");

           }

           else if (response.Equals("cat"))
           {
               Console.WriteLine("You chose the Cat");

           }

           else if (response.Equals("car"))
           {
               Console.WriteLine("You chose the Car");

           }

           else if (response.Equals("truck"))
           {
               Console.WriteLine("You chose the Truck");

           }

           else if (response.Equals("motorcycle"))
           {
               Console.WriteLine("You chose the Motorcycle");

           }
           else
               Console.WriteLine("try again type in all lowercase");
        */


        while (gameFinished == false)
        {
            Console.WriteLine("You are locked in a Hotel and you need to find the three keys to get out. You are in the lobby. Would you like to go right, left, forward, backward, up or down? Type the first letter in lowercase to answer.");
            response = Console.ReadLine();
            while (response != "r" && response != "l" && response != "u" && response != "d" && response != "f" && response != "b")
            {
                Console.WriteLine("You typed it wrong type the first letter in lowercase");
                Console.WriteLine("You are locked in a Hotel and you need to find the key to get out. You are in the lobby. Would you like to go right, left, forward, backward, up or down? Type the first letter in lowercase to answer.");
                response = Console.ReadLine();
            }
            if (response.Equals("r"))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("There is a couch, table and a bed which would you like to look under");
                room = 2;
                response = Console.ReadLine();
            
                if (response.Equals("c"))
                {
                    Console.WriteLine("Under the couch there is a trap door would you like to go down it yes or no");
                    response = Console.ReadLine();
                    if (response.Equals("y"))
                    {
                        Console.WriteLine("YOU FOUND THE RED KEY!!");
                        key1 = true;

                    }
                    else
                    {
                        Console.WriteLine("you go back to beginning");
                        key1 = false;
                    }
                }
                else
                {
                    Console.WriteLine("The keys not here");
                }
            }
            
            else if (response.Equals("l"))
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You are in a room with a TV and couch would you like to look behind the tv or couch?");
                room = 3;
                response = Console.ReadLine();
                if (response.Equals("t"))
                {
                    Console.WriteLine("Theres nothing here");
                }
                else
                {
                    Console.WriteLine("Theres nothing here");
                }
            }
            else if (response.Equals("u"))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You go up you are now on the second floor. Would you like to go down the hallway to the right or left?");
                room = 4;
                response = Console.ReadLine();
                if (response.Equals("r"))
                {
                    Console.WriteLine("Down the hall there is a laundry room would you like to look there yes or no?");
                    room = 5;
                    response = Console.ReadLine();
                    if (response.Equals("y"))
                    {
                        Console.WriteLine("would you like to look by the washer or dryer?");
                        response = Console.ReadLine();
                        if (response.Equals("w"))
                        {
                            Console.WriteLine("YOU FOUND THE GREEN KEY!!!");
                            key2 = true;
                        }
                    }
                    else Console.WriteLine("nothing here");
                }
                else
                    Console.WriteLine("nothing here");


            }
            else if (response.Equals("d"))
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You are in the basement do you want to look around the furnace or water heater ");
                room = 6;
                response = Console.ReadLine();
                if (response.Equals("f"))
                {
                    Console.WriteLine("YOU FOUND THE BLUE KEY!!!");
                    key3 = true;
                }
                else Console.WriteLine("nothing here");
            }
            else if (response.Equals("b"))
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("theres nothing here");
                room = 7;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("You are in a room with a vending macine and table which would you like to look by");
                response = Console.ReadLine();
                if(response.Equals("v"))
                {
                    Console.WriteLine("The keys not here");
                }
                else
                {
                    Console.WriteLine("The keys not here");
                }

            }


            if (key3 == true && key2 == true && key1 == true)
            {
                gameFinished = true;
                Console.WriteLine("YOU FOUND ALL THE KEYS YOU WIN!!!!");
            }
            else gameFinished = false;


        }

       


    }
}