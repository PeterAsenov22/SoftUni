namespace Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            Console.WriteLine("Enter directory path...");
            var folderPath = Console.ReadLine();
            var filePaths = Directory.GetFiles($@"{folderPath}", "*.*", SearchOption.AllDirectories);

            var files = new List<FileInfo>();
            files = filePaths.Select(path => new FileInfo(path)).ToList();

            var sortedFiles = files
                .OrderBy(file => file.Length)
                .GroupBy(file => file.Extension)
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key);

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var streamWriter = new StreamWriter(desktopPath + "/report.txt"))
            {
                foreach (var group in sortedFiles)
                {
                    streamWriter.WriteLine(group.Key);

                    foreach (var file in group)
                    {
                        streamWriter.WriteLine($"--{file.Name} - {(file.Length / 1024.0):F3}kb");
                    }
                }
            }
        }
    }
}
