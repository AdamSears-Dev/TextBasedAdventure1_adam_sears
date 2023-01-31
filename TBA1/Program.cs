using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            /\
           //\\
          ///\\\
         ////\\\\
        /////\\\\\
       //////\\\\\\
      ///////\\\\\\\
     ////////\\\\\\\\
    /////////\\\\\\\\\
   //////////\\\\\\\\\\
  ///////////\\\\\\\\\\\
 ////////////\\\\\\\\\\\\

");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to ~T.B.A.~!");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadKey();
            Console.WriteLine("You find yourself in a dark forest.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"    /\");
            Console.WriteLine(@"   //\\");
            Console.WriteLine(@"  ///\\\");
            Console.WriteLine(@" ////\\\\");
            Console.WriteLine(@"/////\\\\\");
            Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Which way do you want to go? (left, right)");
            string choice = Console.ReadLine();

            if (choice == "left")
            {
                Console.WriteLine("You stumble upon a clearing with a small cottage.");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"
                    ____
                    |  |
    ________________|__|__
   /                      \
  /                        \
 /                          \
/____________________________\
+++++++++++++++++++++++++++++++
|                             |
|                             |
|______________+______________|
|             _|_             |
|____________|   |____________|
|   __       |   |       __   |
|  |  |      |   |      |  |  |
|__|__|______|___|______|__|__|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to enter the cottage? (yes, no)");
                string choice2 = Console.ReadLine();

                if (choice2 == "yes")
                {
                    Console.WriteLine("You find a mustachioed princess who needs your help finding her missing cat.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
                   
                   +++++++++++
    +_+            |  /\_/\  |
   /|_|\           | (='.'=) |
  (o   o)          |(==)_(==)|
 (  ~^~  )         |+++++++++|
  (==)___(==)
  /     \
 /       \
/ ________\       ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want to help her? (yes, no)");
                    string choice3 = Console.ReadLine();

                    if (choice3 == "yes")
                    {
                        Console.WriteLine("You find the cat and return it to the princess.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"
                   
                   
    +_+     
   /|_|\   
  (o   o/\_/\
 (  ~^~(='.'=)   
  (==)(==)_(==)
  /     \
 /       \
/ ________\       ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("She rewards you with a magical amulet and you live happily ever after.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
                   
((       ))
 \\     //
  \\___//
   [ * ]
    \_/");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine("The princess curses you for not helping her and you are stuck in the forest forever.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
            /\                      /\                      /\                      /\
           //\\                    //\\                    //\\                    //\\
          ///\\\                  ///\\\                  ///\\\                  ///\\\
         ////\\\\                ////\\\\                ////\\\\                ////\\\\
        /////\\\\\              /////\\\\\              /////\\\\\              /////\\\\\
       //////\\\\\\            //////\\\\\\            //////\\\\\\            //////\\\\\\
      ///////\\\\\\\          ///////\\\\\\\          ///////\\\\\\\          ///////\\\\\\\
     ////////\\\\\\\\        ////////\\\\\\\\        ////////\\\\\\\\        ////////\\\\\\\\
    /////////\\\\\\\\\      /////////\\\\\\\\\      /////////\\\\\\\\\      /////////\\\\\\\\\
   //////////\\\\\\\\\\    //////////\\\\\\\\\\    //////////\\\\\\\\\\    //////////\\\\\\\\\\
  ///////////\\\\\\\\\\\  ///////////\\\\\\\\\\\  ///////////\\\\\\\\\\\  ///////////\\\\\\\\\\\
 ////////////\\\\\\\\\\\\////////////\\\\\\\\\\\\////////////\\\\\\\\\\\\////////////\\\\\\\\\\\\
                    ");
}
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("You continue through the forest and eventually find your way out.");
                }
            }
            else
            {
                Console.WriteLine("You come across a bandit who steals all your possessions and leaves you for dead.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
                    ___
                   (___)  
                  (_____)  
                 (_______)       
                /  o  o   \
       /\       \ ~~~ ~~~ /
       \/\       \__(____/
        \_\______/       \
         \)_\____     (___\
                 \________/
                  
");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Game Over");
            Console.WriteLine("Press any key to restart the game.");
            Console.ReadKey();
            Main(null);
        }
    }
}
