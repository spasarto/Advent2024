public class Day2
{
    const int MAX = 3;
    public IEnumerable<bool> Run(string input) =>
        input.Split("\n")
             .Select(x => x.Split(" ")
                           .Select(int.Parse))
             .Select(report => report.Zip(report.Skip(1), (x, y) => y - x)
                                     .Aggregate((x: true, y: true), (acc, i) => (acc.x && i > 0 && i <= MAX, acc.y && i < 0 && i >= -MAX)))
             .Select(safe => safe.x || safe.y);
}