namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "somefile.name";
            var fileNameWithSuffix = fileName.AddSuffixToFileName("suffix");
        }
    }
}