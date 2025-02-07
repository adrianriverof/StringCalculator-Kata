namespace Project;

public class StringCalculator {
	static void Main(string[] args) {
		Console.WriteLine("Hello, World!");
	}

	public int Add(string numbers)
	{
		if (numbers == "")
			return 0;

		string[] separated_numbers = numbers.Split(",");
		int value_to_return = 0;
		foreach (var number in separated_numbers)
		{
			value_to_return += int.Parse(number);
		}

		return value_to_return;
		return int.Parse(numbers);
	}
}

