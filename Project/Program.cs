namespace Project;

public class StringCalculator {
	static void Main(string[] args) {
		Console.WriteLine("Hello, World!");
	}

	public int Add(string numbers)
	{
		if (numbers == "")
			return 0;

		string[] separatedNumbers = numbers.Split(
			new string[]{",","\n"}, 
			StringSplitOptions.RemoveEmptyEntries
			);
		int sum = 0;
		
		
		foreach (var number in separatedNumbers)
		{
			sum += int.Parse(number);
		}

		return sum;
	}
}

