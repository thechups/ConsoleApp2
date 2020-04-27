namespace ConsoleApp2
{
    using System.IO;

    public static class StringExtensions
    {
        public static string AddSuffixToFileName(this string fileName, string suffix)
        {
            var directoryName = Path.GetDirectoryName(fileName);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName);

            return Path.Combine(
                directoryName ?? string.Empty,
                string.Concat(fileNameWithoutExtension, suffix, extension));
        }
    }
}