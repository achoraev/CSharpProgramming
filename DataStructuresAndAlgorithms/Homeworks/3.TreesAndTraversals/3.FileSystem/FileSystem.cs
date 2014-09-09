// 3.Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } and using them build a tree keeping all files and folders
// on the hard drive starting from C:\WINDOWS. Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. 
// Use recursive DFS traversal.
namespace FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FileSystem
    {
        private static void Main()
        {            
            string path = "../../";
            var folder = new Folder(".");

            Console.WriteLine("Please wait...");
            FillFolder(path, folder);

            Console.WriteLine(new DirectoryInfo(path).FullName);
    
            folder.PrintRecursive();

            Console.WriteLine("------------------------------");
            folder.Print();

            Console.WriteLine("Folder size is {0:0,0} KB", folder.Size / 1024);
        }

        private static Folder FillFolder(string path, Folder root)
        {
            try
            {
                var source = new DirectoryInfo(path);

                foreach (var file in source.EnumerateFiles())
                {
                    root.AddFile(new File(file.Name, file.Length));                       
                }

                foreach (DirectoryInfo dir in source.EnumerateDirectories())
                {
                    root.AddFolder(FillFolder(dir.FullName, new Folder(dir.Name)));
                }
            }
            catch (System.Exception)
            {
            }

            return root;
        }
    }
}