static class LogLine
{
    public static string Message(string logLine)
    {
        int dotsLocation = logLine.IndexOf(":");

        string theMassegeLine = logLine.Substring(dotsLocation + 1);

        return theMassegeLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int firstBracket = logLine.IndexOf("[");
        int lastBracket = logLine.IndexOf("]");

        string levelMessage = logLine.Substring(firstBracket +1, lastBracket -1 );

        return levelMessage.ToLower();
    }

    public static string Reformat(string logLine)
    {
        int messageStar = logLine.IndexOf(":");

        int firstCurvBr = logLine.IndexOf("[");
        int secondCurvBr = logLine.IndexOf("]");

        string statusMessage = logLine.Substring(firstCurvBr +  1, secondCurvBr - 1).ToLower();

        string finalMessage = logLine.Substring(messageStar + 1).Trim();

        return $"{finalMessage} ({statusMessage})";
    }
}
