using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame;

public static class GameRun
{
	public static void Run(int attempsLeft, int randomNumber)
	{
		int attemps = 0;
		Console.WriteLine("Let's start the game!");

		bool isGameOn = true;
		while (attemps < attempsLeft && isGameOn)
		{
			Console.Write("Enter your guess: ");
			string textNumber = Console.ReadLine();
			int guessNumber = int.Parse(textNumber);

			if (guessNumber == randomNumber)
			{
				attemps++;
				Console.WriteLine($"Congratulations! You guessed the correct number in {attemps} attemps.");
				GameHelper.UpdateHighScore(attemps);
				isGameOn = false;
			}
			else if (guessNumber < randomNumber)
			{
				attemps++;
				Console.WriteLine($"Incorrect! The number is greater than {guessNumber}.");
			}
			else
			{
				attemps++;
				Console.WriteLine($"Incorrect! The number is less than your guess.");
			}
		}
		if (attemps > attempsLeft)
		{
			Console.WriteLine($"You have exhausted all your attempts. The number was {randomNumber}");
		}
	}
}

