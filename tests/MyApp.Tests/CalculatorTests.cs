

namespace MyApp.Tests;

public class CalculatorTests
{
  private readonly Calculator _calculator = new();

  [Fact]
  public void Add_ShouldReturnCorrectSum()
  {
    var result = _calculator.Add(2, 3);
    Assert.Equal(5, result);
  }

  [Fact]
  public void Subtract_ShouldReturnCorrectDifference()
  {
    var result = _calculator.Subtract(5, 3);
    Assert.Equal(2, result);
  }
}