public static class LogAnalysis 
{
       public static string SubstringAfter(this string logString, string delimiter)
    { 
        int dotsLocation = logString.IndexOf(delimiter);
        return logString.Substring(dotsLocation + delimiter.Length); 
    }

       public static string SubstringBetween(this string logString, string dil, string dilTwo)
    { 
        int dilOneLocation = logString.IndexOf(dil) +dil.Length;
        int dilTwoLocation = logString.IndexOf(dilTwo);
        int lengthOfTheLog = dilTwoLocation - dilOneLocation;
        return logString.Substring(dilOneLocation, lengthOfTheLog).Trim(); 
    }    
    
    // TODO: define the 'Message()' extension method on the `string` type
     public static string Message(this string logString)
     {
        return logString.SubstringAfter(":").Trim();
     } 

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logString)
    {
        return logString.SubstringBetween("[","]").Trim();
    }
}