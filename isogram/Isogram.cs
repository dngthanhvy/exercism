using System;
using System.Linq;
public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word.ToLower().Where(c => char.IsLetter(c)).GroupBy(c => c).All(g => g.Count() == 1);
    }
}
