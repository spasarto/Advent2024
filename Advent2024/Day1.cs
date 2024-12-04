namespace Advent2024;

public class Day1
{
    public int Run(int[] one, int[] two) =>
        one.OrderBy(x => x)
           .Zip(two.OrderBy(x => x), (x, y) => Math.Abs(x - y))
           .Sum();
}
