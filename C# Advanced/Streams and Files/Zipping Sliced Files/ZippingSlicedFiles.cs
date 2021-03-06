﻿namespace Zipping_Sliced_Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Text.RegularExpressions;

    public class ZippingSlicedFiles
    {
        private static List<string> files = new List<string>();
        private static MatchCollection match;

        public static void Main()
        {
            var sourcePath = "../../doggo.jpg";
            var destinationPath = "../../";

            Console.Write("Enter number of parts to slice the file: ");
            int numberOfParts = int.Parse(Console.ReadLine());

            Slice(sourcePath, destinationPath, numberOfParts);

            Assemble(files, destinationPath);
        }

        private static void Slice(string sourcePath, string destinationPath, int parts)
        {
            using (var source = new FileStream(sourcePath, FileMode.Open))
            {
                var partSize = (long)Math.Ceiling((double)source.Length / parts);

                var regex = new Regex(@"\.(\w+)$");
                match = regex.Matches(sourcePath);

                for (int i = 0; i < parts; i++)
                {
                    var currPartPath = destinationPath + String.Format($"Part-{i}.gz");
                    files.Add(currPartPath);

                    using (var fileStream = new FileStream(currPartPath, FileMode.Create))
                    {
                        using (var compressionStream = new GZipStream(fileStream, CompressionMode.Compress, false))
                        {
                            long currentPartSize = 0;
                            var buffer = new byte[4096];

                            while (currentPartSize < partSize)
                            {
                                var readBytes = source.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                compressionStream.Write(buffer, 0, readBytes);
                                currentPartSize += readBytes;
                            }
                        }
                    }
                }
            }
        }

        private static void Assemble(List<string> files, string destinationPath)
        {
            string fileOutputPath = destinationPath + String.Format($"assembled.{match[0].Groups[1]}");
            var fileStream = new FileStream(fileOutputPath, FileMode.Create);
            fileStream.Close();

            using (fileStream = new FileStream(fileOutputPath, FileMode.Append))
            {
                foreach (var filePart in files)
                {
                    using (var partSource = new FileStream(filePart, FileMode.Open))
                    {
                        using (var compressionStream = new GZipStream(partSource, CompressionMode.Decompress, false))
                        {
                            var buffer = new byte[4096];
                            while (true)
                            {
                                int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                fileStream.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}
