using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        var hasLetters = false;
        foreach (var c in statement)
        {
            if (char.IsLetter(c))
            {
                hasLetters = true;
                break;
            }
        }

        if (hasLetters && statement.ToUpper() == statement)
        {
            if (statement.EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }
            return "Whoa, chill out!";
        }
        else
        {
            if (statement.EndsWith("?"))
            {
                return "Sure.";
            }
            else if (string.IsNullOrEmpty(statement))
            {
                return "Fine. Be that way!";
            }
            else
            {
                return "Whatever.";
            }
        }
    }


}