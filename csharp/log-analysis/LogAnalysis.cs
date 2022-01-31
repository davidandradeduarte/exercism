using System;

public static class LogAnalysis
{

    private const string infoLevel = "INFO";
    private const string warningLevel = "WARNING";
    private const string errorLevel = "ERROR";
    private static string getFormatedLevel(string level) => $"[{level}]:";

    public static string SubstringAfter(this string line, string after)
    {
        return line.Substring(line.IndexOf(after) + after.Length);
    }

    public static string SubstringBetween(this string line, string first, string second)
    {
        line = line.SubstringAfter(first);
        return line.Substring(0, line.IndexOf(second));
    }

    public static string Message(this string line)
    {
        string getLogMessage(string logLine, string level)
        {
            var formatedLevel = getFormatedLevel(level);
            var index = logLine.IndexOf(formatedLevel);
            var length = formatedLevel.Length;
            return logLine.Substring(index + length).Trim();
        }

        var level = line.Substring(0, line.IndexOf("]"));

        switch (line)
        {
            case var l when l.StartsWith(getFormatedLevel(infoLevel)):
                return getLogMessage(line, infoLevel);
            case var l when l.StartsWith(getFormatedLevel(warningLevel)):
                return getLogMessage(line, warningLevel);
            case var l when l.StartsWith(getFormatedLevel(errorLevel)):
                return getLogMessage(line, errorLevel);
            default:
                throw new NotImplementedException();
        }
    }

    public static string LogLevel(this string line)
    {
        if (line.StartsWith(getFormatedLevel(infoLevel)))
        {
            return infoLevel;
        }
        else if (line.StartsWith(getFormatedLevel(warningLevel)))
        {
            return warningLevel;
        }
        else if (line.StartsWith(getFormatedLevel(errorLevel)))
        {
            return errorLevel;
        }
        else
        {
            throw new NotImplementedException("Unimplemented log level");
        }
    }
}