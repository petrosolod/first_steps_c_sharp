public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        
        string first = phoneNumber.Substring(0,3);
        string middle = phoneNumber.Substring(4,3);
        string end = phoneNumber[^4..];

        bool IsNewYork = (first == "212");
        bool IsFake = (middle == "555");

        return (IsNewYork, IsFake, end);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
