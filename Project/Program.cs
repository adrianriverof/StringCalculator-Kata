namespace Project;

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
		
		
		foreach (var number in separatedNumbers)
		{
			sum += int.Parse(number);
		}

		return sum;
	}
}

