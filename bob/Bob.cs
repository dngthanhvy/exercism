using System;
using System.Linq;

public static class Bob
{
    public static bool IsQuestion(string statement) { return statement.EndsWith("?"); }
    
    public static bool IsYelling(string statement) { return statement.ToUpper() == statement && statement.Any(char.IsLetter); }
    
    public static bool IsStatementEmpty(string statement) { return String.IsNullOrWhiteSpace(statement); }
    
    public static string Response(string statement)
    {
        string trimmedStatement = statement.Trim();
        if (IsQuestion(trimmedStatement))
        {
            if (IsYelling(trimmedStatement)) return "Calm down, I know what I'm doing!";
            else return "Sure.";
        } 
        else if (IsYelling(trimmedStatement)) return "Whoa, chill out!";
        else if (IsStatementEmpty(trimmedStatement)) return "Fine. Be that way!";
        else return "Whatever.";
    }
}