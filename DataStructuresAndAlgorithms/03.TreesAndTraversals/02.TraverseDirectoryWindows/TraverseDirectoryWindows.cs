namespace TraverseDirectoryWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TraverseDirectoryWindows
    {
        // 02.Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and 
        //    to display all files matching the mask *.exe. Use the class System.IO.Directory.

        private static List<string> files = new List<string>();

        public static void Main()
        {
            // Problems with access denied in windows folder
            //string rootPath = @"C:\WINDOWS";
            string rootPath = @"C:\Program Files";
            //string rootPath = @"C:\Program Files (x86)";
            //string fileExtension = "*.dll";
            string fileExtension = "*.exe";

            TraverseDirectory(rootPath, fileExtension);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        private static void TraverseDirectory(string currentPath, string fileExtension)
        {
            string[] currentDirFiles = Directory.GetFiles(currentPath, fileExtension);
            files.AddRange(currentDirFiles);

            string[] curretDirDirectories = Directory.GetDirectories(currentPath);
            foreach (var dir in curretDirDirectories)
            {
                TraverseDirectory(dir, fileExtension);
            }
        }
    }
}
