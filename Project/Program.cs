namespace Project;

public class StringCalculator {
	static void Main(string[] args) {
		Console.WriteLine("Hello, World!");
	}

	public int Add(string numbers)
	{
		if (numbers == "")
			return 0;

		string[] separatedNumbers = numbers.Split(",");
		int valueToReturn = 0;
		
		
		foreach (var number in separatedNumbers)
		{
			valueToReturn += int.Parse(number);
		}

		return valueToReturn;
	}
}

