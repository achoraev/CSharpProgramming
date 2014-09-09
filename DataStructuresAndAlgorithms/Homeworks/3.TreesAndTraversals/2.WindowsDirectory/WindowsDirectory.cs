// 1.Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. 
// Use the class System.IO.Directory.
namespace WindowsDirectory
{
    using System;
    using System.IO;

    public class WindowsDirectory
    {
        private static void Main()
        {            
            string path = "C:\\WINDOWS";
            string pattern = "*.exe";
            SearchDir(new DirectoryInfo(path), pattern);
        }

        private static void SearchDir(DirectoryInfo dir, string mask)
        {
            try
            {
                SearchFileInFolder(dir, mask);
                foreach (DirectoryInfo child in dir.EnumerateDirectories())
                {
                    SearchDir(child, mask);
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Access to this folder denied...");
            }
        }

        private static void SearchFileInFolder(DirectoryInfo dir, string mask)
        {
            foreach (var file in dir.EnumerateFiles(mask))
            {
                Console.WriteLine(file.FullName.Substring(dir.FullName.Length + 1));
            }
        }

        private static void TraverseDir(DirectoryInfo dir, int indent)
        {
            try
            {
                Console.WriteLine(new string(' ', indent) + dir.Name);

                DirectoryInfo[] children = dir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    TraverseDir(child, indent + 2);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access to this folder denied...");
            }
        }
    }
}