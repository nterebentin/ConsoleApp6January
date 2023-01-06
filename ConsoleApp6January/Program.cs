using System.IO;

namespace ConsoleApp6January

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("c:\\");
             var dirList = di.GetDirectories();

            foreach(var folder in dirList)
            {
                Console.WriteLine(folder.Name);
            }

        }
        static void Dön (DirectoryInfo di)
        {
            var dirList = di.GetDirectories();
            foreach (var folder in dirList)

            {
                Console.WriteLine (folder.Name);
                Dön(folder);
            }
        }
    }
}