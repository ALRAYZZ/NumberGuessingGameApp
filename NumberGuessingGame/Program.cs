
using NumberGuessingGame;

Random random = new Random();
int minValue = 1;
int maxValue = 100;
int randomNumber = random.Next(minValue, maxValue + 1);


Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine($"I am thinking a number between 1 and {maxValue}.");
Console.WriteLine("Please select the difficulty level:");
Console.WriteLine("1. Easy (10 attempts)");
Console.WriteLine("2. Medium (5 attempts)");
Console.WriteLine("3. Hard (3 attempts)");

int attempsLeft = GameHelper.GetDifficultyLevel();


bool isGameOn = true;
while (isGameOn)
{
	GameRun.Run(attempsLeft, randomNumber);





	Console.Write("Do you want to play again? (yes/no): ");
	string playAgain = Console.ReadLine();
	if (playAgain.ToLower() != "yes")
	{
		isGameOn = false;
	}
	else
	{
		randomNumber = random.Next(minValue, maxValue + 1);
	}
}


