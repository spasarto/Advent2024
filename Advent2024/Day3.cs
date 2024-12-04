

using System.Text.RegularExpressions;

public partial class Day3
{
    [GeneratedRegex(@"mul\((\d{1,3})\,(\d{1,3})\)", RegexOptions.IgnoreCase)]
    private static partial Regex _regex();

    public int Run(string input) =>
        _regex().Matches(input)
                .Select(m => (m.Groups[1].Value, m.Groups[2].Value))
                .Select(x => (int.Parse(x.Item1), int.Parse(x.Item2)))
                .Select(x => x.Item1 * x.Item2)
                .Sum();
}