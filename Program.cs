using Xunit;

public class UnitTests
{
    // Facts are parameterless tests. 
    // If it passes, the functionality works. 
    [Fact]
    // Each method equates to a single "test". In order to pass a test, your code may need to pass multiple assertions.
    // You can think of it kind of like questions on a written test. You can pass some questions, but not the test.
    public void TestFact()
    {
        Assert.Equal(8, int.Parse("8"));
    }

    // Theories are tests with parameters, and can have multiple data sets.
    // They are used to test things which can expect a wide range of inputs. 
    // They typically are written with boundary inputs (IE if 1-10 should work, test -1, 0, 1, 10 and 11).
    // Theories aren't always bulletproof (for example if 3 didn't work in the above example, it wouldn't be caught), but they are usually "good enough" as opposed to testing potentially hundreds of thousands of inputs.
    [Theory,
        InlineData(1, 1, 2),
        InlineData(2, 3, 5),
        InlineData(5, 7, 12)]
    public void TestTheory(int param1, int param2, int expectedResult)
    {
        int actualResult = param1 + param2;
        Assert.Equal(expectedResult, actualResult);
    }

}