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

    [TestMethod]
    public void Day3()
    {
        var input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

        var result = new Day3().Run(input);

        Assert.AreEqual(161, result);
    }

    [TestMethod]
    public void Day4()
    {
        var input =
@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX";
        var result = new Day4().Run(input);
        Assert.AreEqual(18, result);
    }
}