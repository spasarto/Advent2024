public class Day4
{
    static readonly char[] xmas = "XMAS".ToCharArray();

    public int Run(string input)
    {
        int newline = input.IndexOf('\n');
        int len = input[newline - 1] == '\r' ? newline + 1 : newline;
        int[] indices = [-len - 1, -len, -len + 1, -1, 1, len - 1, len, len + 1];

        return input.Select((c, i) => (c, i))
                    .Where(x => x.c == 'X')
                    .Select(x => indices.Where(di => Check(x.i + di, di, 1, input)).Select(ii => 1).Sum())
                    .Sum();
    }

    private static bool Check(int i, int di, int c, string input)
    {
        if (c == xmas.Length)
        {
            return true;
        }
        if (i < 0 || i >= input.Length || input[i] != xmas[c])
        {
            return false;
        }

        return Check(i + di, di, c + 1, input);
    }
}
