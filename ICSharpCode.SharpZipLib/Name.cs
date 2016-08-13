namespace ICSharpCode.SharpZipLib
{
    public static class Name
    {
        public static string Of<T>(T argument)
        {
            return typeof (T).ToString();
        }
    }
}