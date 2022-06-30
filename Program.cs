using System.Text.RegularExpressions;
using Xunit;


public class UnitTests
{
    bool TestValidEmail(string email)
    // Tests to ensure the phone number entered follows the format mask "text@text.text".  Returns true if so, and false if not.
    // Rules special characters other than periods and underscores as invalid.
    {
        return new Regex(@"^[\w.]+@[\w.]+[\w]+$").IsMatch(email);
    }
    bool TestValidPhoneNumber(string phone)
    // Tests to ensure the phone number entered follows the format mask "###-###-####".  Returns true if so, and false if not.
    {
        return new Regex(@"^\d{3}-d{3}-d{4}$").IsMatch(phone);
    }
    bool TestValidNumber(int number)
    // Tests to ensure the number entered is between 1 and 100 inclusive. Returns true if so, and false if not.
    {
        return number >= 1 && number <= 100;
    }

    [Theory,
        InlineData("text@text.text", true),
        InlineData("texttext.text", false),
        InlineData("text@texttext", false),
        InlineData("texttexttext", false),
        InlineData("te-xt@text.text", false),
        InlineData("te_xt@text.text", true),
        InlineData("te.xt@text.text", true)]
    public void Test_Email(string toTest, bool expectedResult)
    {
        Assert.Equal(expectedResult, TestValidEmail(toTest));
    }


    [Theory,
        InlineData("123-456-7890", true),
        InlineData("123456-7890", false),
        InlineData("123-4567890", false),
        InlineData("1234567890", false),
        InlineData("1234-456-7890", false),
        InlineData("123-4566-7890", false),
        InlineData("123-456-78900", false),
        InlineData("12-456-7890", false),
        InlineData("123-45-7890", false),
        InlineData("123-456-789", false),
        InlineData("Random Text", false)]
    public void Test_Phone(string toTest, bool expectedResult)
    {
        Assert.Equal(expectedResult, TestValidPhoneNumber(toTest));
    }

    [Theory,
        InlineData(-1, false),
        InlineData(0, false),
        InlineData(1, true),
        InlineData(100, true),
        InlineData(101, false),
        InlineData(42, true),
        InlineData(50, true)]
    public void Test_Number(int toTest, bool expectedResult)
    {
        Assert.Equal(expectedResult, TestValidNumber(toTest));
    }

}



