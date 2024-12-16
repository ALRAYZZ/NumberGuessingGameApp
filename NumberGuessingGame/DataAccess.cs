using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame;

public static class DataAccess
{
	private static readonly string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Highscore");
	private static readonly string filePath = Path.Combine(folderPath, "highscore.txt");
	public static void WriteToFile(string content)
	{
		Directory.CreateDirectory(folderPath);
		File.WriteAllText(filePath, content);		
	}

	public static string ReadFromFile()
	{
		if (File.Exists(filePath))
		{
			return File.ReadAllText(filePath);
		}
		else
		{
			return null;
		}
	}
}
