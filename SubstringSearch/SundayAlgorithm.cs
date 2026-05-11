namespace SubstringSearch;

public class SundaySearch
{
    // Returns the index of the first occurrence of pattern p in text t, or -1 if not found
    public static int Search(string p, string t)
    {
        int m = p.Length;
        int n = t.Length;

        var last = BuildLastOccurrence(p);

        int i = 0;
        while (i <= n - m)
        {
            if (t[i..(i + m)] == p) return i;
            if (i == n - m) break;
            i += SundayShift(t[i + m], m, last);
        }

        return -1;
    }

    // Builds a table of the last occurrence index of each character in the pattern
    private static Dictionary<char, int> BuildLastOccurrence(string p)
    {
        var last = new Dictionary<char, int>();
        for (int i = 0; i < p.Length; i++)
            last[p[i]] = i;
        return last;
    }

    // How far to shift: if char is in pattern, shift to align it; otherwise skip past it
    private static int SundayShift(char c, int m, Dictionary<char, int> last)
    {
        return last.ContainsKey(c) ? m - last[c] : m + 1;
    }
}