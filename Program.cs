using System;

namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			//variables
			Random randNum = new Random();
			int computerChoice;
			int userWin = 0;
			int computerWin = 0;
			int tie = 0;
			int convertedNumber = -1;
			bool conversionBool = false;
			bool continueGame = true;

			//get input form the user
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");

			while (continueGame)
			{
				do
				{
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					string userInput = Console.ReadLine();
					computerChoice = randNum.Next(1, 4);

					//validate the use input as a 1, 2, or 3
					//this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.
					conversionBool = Int32.TryParse(userInput, out convertedNumber);
					if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
					{
						Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
					}

				} while (!(convertedNumber > 0 && convertedNumber < 4));
				//Console.WriteLine($"The int converted value inputted is {convertedNumber}");

				if (convertedNumber == 1 && computerChoice == 2)
				{
					Console.WriteLine("You chose Rock. Computer chose Paper. Computer wins!");
					++computerWin;
				}
				else if (convertedNumber == 1 && computerChoice == 3)
                   {
					Console.WriteLine("You chose Rock. Computer chose Scissors. You win!");
					++userWin;
				}
				else if (convertedNumber == 2 && computerChoice == 1)
                {
					Console.WriteLine("You chose Paper. Computer chose Rock. You win!");
					++userWin;
				}
				else if (convertedNumber == 2 && computerChoice == 3)
                {
					Console.WriteLine("You chose Paper. Computer chose Scissors. Computer wins!");
					++computerWin;
				}
				else if (convertedNumber == 3 && computerChoice == 1)
                {
					Console.WriteLine("You chose Scissors. Computer chose Rock. Computer wins!");
					++computerWin;
				}
				else if (convertedNumber == 3 && computerChoice == 2)
                {
					Console.WriteLine("You chose Scissors. Computer chose paper. You win!");
					++userWin;
				}
                else if (convertedNumber == computerChoice)
                {
                    Console.WriteLine("It's a tie");
                    ++tie;
				}

				if(computerWin >= 2 || userWin >= 2)
                {
					Console.WriteLine("Computer wins: " + computerWin + "\nUser wins: " + userWin + "\nTies: " + tie);
					continueGame = false;
                }
			} 
			

			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			 * 
			 * 
			 * 
			 * 
			**/




		}
	}
}
