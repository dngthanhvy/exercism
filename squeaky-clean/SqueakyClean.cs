using System;
using System.Linq;

public static class Identifier {
    
    static bool IsLowerCaseGreekLetter(char c) {
        return c >= 'α' && c <= 'ω';
    }
    
    public static string Clean(string identifier) {
        bool dash = false;
        var result = new System.Text.StringBuilder();
        foreach (char c in identifier) {
            if (dash == true) {
                result.Append(char.ToUpper(c));
                dash = false;
            } else if (c == '-') {
                dash = true;
            } else if (char.IsControl(c)) {
                result.Append("CTRL");
            } else if (c == ' ') {
                result.Append('_');
            } else if (IsLowerCaseGreekLetter(c) || !char.IsLetter(c)) {
                continue;
            } else {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
