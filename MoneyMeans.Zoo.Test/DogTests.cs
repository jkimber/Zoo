namespace MoneyMeans.Zoo.Test;

public class DogTests
{
    [Test]
    public void Dog_Returns_Woof_When_Bark_Is_Called()
    {
        // Arrange
        var sut = new Dog();

        // Act
        var result = sut.Talk();

        // Assert
        Assert.That(result, Is.EqualTo("Woof"));
    }

    [TestCase(3, "Ouch")]
    [TestCase(2, "Ouch")]
    [TestCase(0, "Ouch")]
    [TestCase(1, "Ouch")]
    [TestCase(4, "Woof")]
    [TestCase(8, "Woof")]
    public void Given_ADog_When_ItHasANumberOfLegs_ThenItReturnsExpectedSpeech(
        int numberofLegs, string expected)
    {
        // Arrange
        var sut = new Dog();
        sut.NumberOfLegs = numberofLegs;

        // Act
        var result = sut.Talk();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GivenACat_WhenTalkIsCalled_ItReturnsExpectedSpeech()
    {
        // Arrange
        var sut = new Cat();

        // Act
        var result = sut.Talk();

        // Assert
        Assert.That(result, Is.EqualTo("Meow"));
    }

    [Test]
    public void GivenAHuman_WhenNumberOfLegsIsOne_TalkReturnsImHoppingMad()
    {
        // Arrange
        var sut = new Human();

        // Act
        var result = sut.Talk();

        // Assert
        Assert.That(result, Is.EqualTo("I'm hopping mad!"));
    }

    [Test]
    public void GivenAHuman_WhenTalkIsCalled_TalkReturnsHello()
    {
        // Arrange
        var sut = new Human();

        // Act
        var result = sut.Talk();

        // Assert
        Assert.That(result, Is.EqualTo("Hello"));
    }
}