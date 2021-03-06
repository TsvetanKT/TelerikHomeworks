﻿namespace FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Numerics;

    class FileSystem
    {
        // 03. Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders }
        //      and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. Implement 
        //      a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. Use recursive DFS traversal.

        public static Folder MakeFilesTree(Folder root)
        {
            var folders = Directory.EnumerateDirectories(root.Name);
            var files = Directory.GetFiles(root.Name);
            root = AddFilesToDirectory(root, files);
            root = AddChildFoldersToDirectory(root, folders);
            for (int i = 0; i < root.ChildFolders.Length; i++)
            {
                try
                {
                    root.ChildFolders[i] = MakeFilesTree(root.ChildFolders[i]);
                }
                catch (Exception)
                {
                    //This way we scip the files witouth acces
                    continue;
                }
            }
            return root;
        }
        private static Folder AddChildFoldersToDirectory(Folder root, IEnumerable<string> folders)
        {
            List<Folder> directpryFolders = new List<Folder>();
            foreach (var item in folders)
            {
                Folder folder = new Folder(item.ToString());
                directpryFolders.Add(folder);
            }
            root.ChildFolders = directpryFolders.ToArray();
            return root;
        }
        private static Folder AddFilesToDirectory(Folder root, string[] files)
        {
            List<File> directoryFiles = new List<File>();
            foreach (var item in files)
            {
                FileInfo fileInfo = new FileInfo(item);
                long size = fileInfo.Length;
                File file = new File(item.ToString(), size);
                directoryFiles.Add(file);
            }
            root.Files = directoryFiles.ToArray();
            return root;
        }
        public static void PrintTree(Folder root, string spaces)
        {
            Console.WriteLine(spaces + root.Name);
            foreach (var folder in root.ChildFolders)
            {
                PrintTree(folder, spaces + " ");
            }
            foreach (var file in root.Files)
            {
                Console.WriteLine(spaces + " " + file.Name + " --FileSize: " + file.Size);
            }
        }
        public static BigInteger CalculateSizesOfSubTreee(Folder startFolder, int deptOfSubtree)
        {
            BigInteger sum = 0;
            foreach (var file in startFolder.Files)
            {
                sum += (BigInteger)file.Size;
            }
            if (deptOfSubtree == 0)
            {
                return sum;
            }
            else
            {
                foreach (var folder in startFolder.ChildFolders)
                {
                    sum += CalculateSizesOfSubTreee(folder, deptOfSubtree - 1);
                }
                return sum;
            }
        }
        static void Main()
        {
            try
            {
                //string directoryName = @"C:\Windows";
                string directoryName = @"C:\Program Files";
                Folder cWindows = new Folder(directoryName);
                cWindows = MakeFilesTree(cWindows);
                PrintTree(cWindows, "");
                BigInteger sum = CalculateSizesOfSubTreee(cWindows, 1);
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!" + e.Message);
            }
        }
    }
}
