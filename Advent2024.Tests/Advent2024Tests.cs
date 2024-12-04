namespace Advent2024.Tests;

[TestClass]
public class Advent2024Tests
{
    [TestMethod]
    public void Day1()
    {
        var one = new int[] { 3, 4, 2, 5, 1, 3, 3 };
        var two = new [] { 4, 3, 5, 3, 9, 3 };

        var result = new Day1().Run(one, two);

        Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void Day2()
    {
        var input = 
@"7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9";

        var reports = new Day2().Run(input);

        var expectedResults = new bool[] { true, false, false, false, false, true };

        var actualAndExpected = reports.Zip(expectedResults);
        foreach(var (actual,expected) in actualAndExpected)
        {
            Assert.AreEqual(expected,actual);
        }
    }
}