using Project;
namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void Test1() {
		Assert.Pass();
	}

	[Test]

	public void add_returns_0_when_nothing_passed()
	{
		StringCalculator sut = new StringCalculator();
		
		Assert.That(sut.Add(""), Is.EqualTo(0));
		
	}
	[Test]

	public void returns_number_if_only_one()
	{
		StringCalculator sut = new StringCalculator();
		
		Assert.That(sut.Add("4"), Is.EqualTo(4));
		
	}
	[Test]
	public void otherexample_returns_number_if_only_one()
	{
		StringCalculator sut = new StringCalculator();
		
		Assert.That(sut.Add("46"), Is.EqualTo(46));
		
	}
	[Test]
	public void add_two_numbers_1_plus_1_is_2()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1,1"), Is.EqualTo(2));
	}
	[Test]
	public void add_3_plus_65_equals_68()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("3,65"), Is.EqualTo(68));
	}

	[Test]
	public void add_multiple_numbers_1_3_times()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1,1,1"), Is.EqualTo(3));
	}
	[Test]
	public void add_multiple_numbers_1_10_times()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1,1,1,1,1,1,1,1,1,1"), Is.EqualTo(10));
	}
	[Test]
	public void add_multiple_numbers_not_just_ones()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1,1,1,1,1,2,2,1,1,1"), Is.EqualTo(12));
	}
	[Test]
	public void use_newline_separator()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1\n1"), Is.EqualTo(2));
	}
	[Test]
	public void combine_newline_comma()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1\n1,3"), Is.EqualTo(5));
	}

	[Test]
	public void custom_separators()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("//;\n1;2"), Is.EqualTo(3));
	}
	[Test]
	public void custom_separators_other_separator()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("//a\n1a2a4"), Is.EqualTo(1+2+4));
	}
	[Test]
	public void custom_separator_can_be_percent()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("//%\n1%2%4"), Is.EqualTo(1+2+4));
	}
	[Test]
	public void negatives_not_allowed_using_same_number()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(() => sut.Add("-1,-3,-3"), Throws.Exception.With.Message.EqualTo("error: negatives not allowed: -1 -3 -3"));
	}

	[Test]
	public void ignore_numbers_bigger_than_1000()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("1003,2"), Is.EqualTo(2));
	}

	[Test][Ignore("not implemented yet")]
	public void separators_can_be_lenghy_if_surrounded_by_sqbrackets()
	{
		StringCalculator sut = new StringCalculator();
		Assert.That(sut.Add("//[***]\n1***2***4"), Is.EqualTo(1+2+4));
	}
}