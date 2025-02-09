namespace Project;

public class StringCalculator {
	static void Main(string[] args) {
		Console.WriteLine("Hello, World!");
	}

	public int Add(string numbers)
	{

		string[] separatedNumbers;
		
		// we need to change this so we can find where the string starts (\n)
		// and allow to find the separator (surrounded by [])
		//


		if (numbers.StartsWith("//"))
		{
			string separator = numbers[2].ToString();
			int startPosition = numbers.IndexOf("\n");
			
			if (numbers.StartsWith("//["))
			{
				int separatorLength = startPosition - 2;
				separator = numbers.Substring(3, 3);
			}
			
			separatedNumbers = numbers.Substring(startPosition).Split(
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

			if (numberInt > 1000)  // number class???
			{
				numberInt = 0;
			}
			sum += numberInt;
		}

		ThrowErrorIfThereAreNegatives(negatives);
		
		return sum;
	}

	private static void ThrowErrorIfThereAreNegatives(List<int> negatives)
	{
		if (negatives.Count != 0)
		{
			string errorMessage = "error: negatives not allowed:";
			foreach (var negativeNumber in negatives)
			{
				errorMessage = errorMessage + " " + negativeNumber;
			}

			throw new Exception(errorMessage);
		}
	}
}

