using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame;

public class GameHelper
{
	public static int GetDifficultyLevel()
	{
		bool chooseDifficulty = true;
		int attempts = 0;
		while (chooseDifficulty)
		{
			Console.Write("Enter the difficulty level: ");
			string diffLevel = Console.ReadLine();
			if (diffLevel == "1")
			{
				Console.WriteLine("Great You have selected the Easy difficulty level");
				attempts = 10;
				chooseDifficulty = false;
			}
			else if (diffLevel == "2")
			{
				Console.WriteLine("Great You have selected the Medium difficulty level");
				attempts = 5;
				chooseDifficulty = false;
			}
			else if (diffLevel == "3")
			{
				Console.WriteLine("Great You have selected the Hard difficulty level");
				attempts = 3;
				chooseDifficulty = false;
			}
			else
			{
				Console.WriteLine("Invalid difficulty level selected. Please select a valid difficulty level.");
			}
		}
		return attempts;
	}

	public static void UpdateHighScore(int attemps)
	{
		string pastAttempsText = DataAccess.ReadFromFile();

		if (pastAttempsText == null)
		{
			DataAccess.WriteToFile(attemps.ToString());
		}
		else
		{
			int pastAttemps = int.Parse(pastAttempsText);
			if (attemps < pastAttemps)
			{
				DataAccess.WriteToFile(attemps.ToString());
			}
		}
	}
}
