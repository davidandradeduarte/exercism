using System;

static class LogLine
{
    private const string infoLevel = "INFO";
    private const string warningLevel = "WARNING";
    private const string errorLevel = "ERROR";
    private static string getFormatedLevel(string level) => $"[{level}]:";
    private static string getLogMessage(string logLine, string level)
    {
        var formatedLevel = getFormatedLevel(level);
        var index = logLine.IndexOf(formatedLevel);
        var length = formatedLevel.Length;
        return logLine.Substring(index + length).Trim();
    }

    public static string Message(string logLine)
    {
        if (logLine.StartsWith(getFormatedLevel(infoLevel)))
        {
            return getLogMessage(logLine, infoLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(warningLevel)))
        {
            return getLogMessage(logLine, warningLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(errorLevel)))
        {
            return getLogMessage(logLine, errorLevel);
        }
        else
        {
            throw new NotImplementedException("Unimplemented log level");
        }
    }

    public static string LogLevel(string logLine)
    {
        string getLogLevel(string level) => level.ToLower();

        if (logLine.StartsWith(getFormatedLevel(infoLevel)))
        {
            return getLogLevel(infoLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(warningLevel)))
        {
            return getLogLevel(warningLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(errorLevel)))
        {
            return getLogLevel(errorLevel);
        }
        else
        {
            throw new NotImplementedException("Unimplemented log level");
        }
    }

    public static string Reformat(string logLine)
    {
        string reformat(string level)
        {
            var message = getLogMessage(logLine, level);
            var l = level.ToLower();
            return $"{message} ({l})";
        }

        if (logLine.StartsWith(getFormatedLevel(infoLevel)))
        {
            return reformat(infoLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(warningLevel)))
        {
            return reformat(warningLevel);
        }
        else if (logLine.StartsWith(getFormatedLevel(errorLevel)))
        {
            return reformat(errorLevel);
        }
        else
        {
            throw new NotImplementedException("Unimplemented log level");
        }
    }
}
