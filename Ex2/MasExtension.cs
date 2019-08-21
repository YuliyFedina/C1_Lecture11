namespace Ex2
{
    public static class MasExtension
    {
        public static string MasThroughSeparator(this int[] mas, string separator)
        {
            return string.Join(separator, mas);
        }
    }
}
