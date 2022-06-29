using System.Text.RegularExpressions;
using Xunit;

public class UnitTests
{
    /* Must: Not contain numbers, must contain only capital letters, must contain exactly 2 spaces (not at the beginning or end).
    * 
    * "1 234 5"
    * "H E1L O"
    * "h ell o"
    * "H Ell O"
    * " HELLO "
    * "HE LLO"
    * "HELLO"
    * "H E L L O"
    * 
    */
    bool FunkyTest(string toTest)
    // TODO: Fix RegEx implementation.
    {
        bool isValid = true;
        if (toTest.Any(x => char.IsNumber(x)))
        // new Regex(@"\d").IsMatch(toTest)
        {
            isValid = false;
        }
        if (toTest.Any(x => !char.IsUpper(x) && x != ' '))
        // new Regex(@"[a-z]").IsMatch(toTest)
        {
            isValid = false;
        }
        if (toTest[0] == ' ' || toTest[toTest.Length - 1] == ' ' || toTest.Count(x => x == ' ')!=2)
        // new Regex(@"^[^ ]+ .* [^ ]+$").IsMatch(toTest)
        {
            isValid = false;
        }

        return isValid;
    }


    [Theory,
        InlineData("1 234 5", false),
        InlineData("H E1L O", false),
        InlineData("h ell o", false),
        InlineData("H Ell O", false),
        InlineData(" HELLO ", false),
        InlineData("HE LLO", false),
        InlineData("HELLO", false),
        InlineData("H E L L O", false),
        InlineData("H ELL O", true)]
    public void Test_FunkyTest(string toTest, bool expectedResult)
    {
        Assert.Equal(expectedResult, FunkyTest(toTest));
    }
    /*

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
    */
}



