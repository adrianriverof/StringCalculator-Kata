﻿namespace Project;

public class StringCalculator {
	static void Main(string[] args) {
		Console.WriteLine("Hello, World!");
	}

	public int Add(string numbers)
	{
		if (numbers == "")
			return 0;


		string[] separatedNumbers;
		
		if (numbers.StartsWith("//"))
		{
			string separator = numbers[2].ToString();
			separatedNumbers = numbers.Substring(4).Split(
				new string[]{separator}, 
				StringSplitOptions.RemoveEmptyEntries
			);
		}
		else
		{
			separatedNumbers = numbers.Split(
				new string[]{",","\n"}, 
				StringSplitOptions.RemoveEmptyEntries
			);
		}

		int sum = 0;

		
		List<int> negatives = new List<int>();
		
		foreach (var number in separatedNumbers)
		{
			int numberInt = int.Parse(number);
			if (numberInt < 0)
			{
				negatives.Add(numberInt);
			}

			if (numberInt > 1000)
			{
				numberInt = 0;
			}
			sum += numberInt;
		}

		if (negatives.Count != 0)
		{
			string errorMessage = "error: negatives not allowed:";
			foreach (var negativeNumber in negatives)
			{
				errorMessage = errorMessage + " " + negativeNumber.ToString();
			}

			throw new Exception(errorMessage);
		}
		
		return sum;
	}
}

