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
		
		Assert.That(sut.Add("46456"), Is.EqualTo(46456));
		
	}

	
	
	
	
}