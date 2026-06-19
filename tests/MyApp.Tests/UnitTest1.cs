namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(1, 1);   // obviously wrong
    }
}
