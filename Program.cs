using System;

namespace csharp_rps
{
  class Program
  {
    static void Main(string[] args)
    {
      int player = 0;
      int computer = 0;
      Console.WriteLine("Welcome, what is your name?");
      string name = Console.ReadLine();
      Console.WriteLine("Hi " + name + ", are you ready to play rock, paper scissors?");
      string response = Console.ReadLine();
      bool play = true;
      while (play)
      {

        Console.WriteLine(@"Sweet, choose one of the following
                _    
               | |   
 _ __ ___   ___| | __
| '__/ _ \ / __| |/ /
| | | (_) | (__|   < 
|_|  \___/ \___|_|\_\

 _ __   __ _ _ __   ___ _ __ 
| '_ \ / _` | '_ \ / _ \ '__|
| |_) | (_| | |_) |  __/ |   
| .__/ \__,_| .__/ \___|_|   
| |         | |              
|_|         |_|       
          _                        
         (_)                       
 ___  ___ _ ___ ___  ___  _ __ ___ 
/ __|/ __| / __/ __|/ _ \| '__/ __|
\__ \ (__| \__ \__ \ (_) | |  \__ \
|___/\___|_|___/___/\___/|_|  |___/
                                   
                                   ");

        string choice = Console.ReadLine().ToLower();
        if (choice == "rock")
        {
          Console.WriteLine("Rock, that was a hard choice, haha.");
        }
        else if (choice == "paper")
        {
          Console.WriteLine("Paper, simple and flimsy choice.");
        }
        else
        {
          Console.WriteLine("Scissors, you're sharper than I thought.");
        }
        Console.WriteLine("Are you ready to see the computer's choice?");
        response = Console.ReadLine().ToLower();
        Random mathRandomTool = new Random();
        int number = mathRandomTool.Next(1, 4);
        if (number == 1)
        {
          Console.WriteLine(@"The computer chose 
                _    
               | |   
 _ __ ___   ___| | __
| '__/ _ \ / __| |/ /
| | | (_) | (__|   < 
|_|  \___/ \___|_|\_\

          ");
          if (choice == "rock")
          {
            Console.WriteLine("It's a draw.");
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else if (choice == "paper")
          {
            Console.WriteLine("You win, congrats!");
            player += 1;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else
          {
            Console.WriteLine("Computer wins!");
            computer += 1;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
        }
        if (number == 2)
        {
          Console.WriteLine(@"The computer chose 
          
 _ __   __ _ _ __   ___ _ __ 
| '_ \ / _` | '_ \ / _ \ '__|
| |_) | (_| | |_) |  __/ |   
| .__/ \__,_| .__/ \___|_|   
| |         | |              
|_|         |_|     
                
          ");
          if (choice == "rock")
          {
            Console.WriteLine("Computer wins!");
            computer += 1;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else if (choice == "paper")
          {
            Console.WriteLine("It's a draw.");
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else
          {
            Console.WriteLine("You win, congrats!");
            player += 1;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
        }
        if (number == 3)
        {
          Console.WriteLine(@"The computer chose   
          _                        
         (_)                       
 ___  ___ _ ___ ___  ___  _ __ ___ 
/ __|/ __| / __/ __|/ _ \| '__/ __|
\__ \ (__| \__ \__ \ (_) | |  \__ \
|___/\___|_|___/___/\___/|_|  |___/    
               
          ");
          if (choice == "rock")
          {
            Console.WriteLine("You win, congrats!");
            player++;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else if (choice == "paper")
          {
            Console.WriteLine("Computer wins!");
            computer += 1;
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
          else
          {
            Console.WriteLine("It's a draw.");
            Console.WriteLine("Player score: " + player + "  Computer score: " + computer);
          }
        }
        Console.WriteLine("Want to play again?");
        response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
          continue;
        }
        else
        {
          Console.WriteLine("Goodbye.");
          return;
        }
      }

    }
  }
}


