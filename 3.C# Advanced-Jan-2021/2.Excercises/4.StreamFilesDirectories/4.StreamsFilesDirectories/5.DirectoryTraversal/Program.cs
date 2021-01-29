using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> files = new Dictionary<string, Dictionary<string, double>>();
            string directoryPath = "";
            string[] fileNames = Directory.GetFiles(Directory.GetCurrentDirectory());

            foreach (string file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extention = fileInfo.Extension;
                double kbSize = Math.Round(fileInfo.Length / 1024.0, 3);

                if (!files.ContainsKey(extention))
                {
                    files.Add(extention, new Dictionary<string, double>());
                }

                files[extention].Add(file, kbSize);
            }

            List<string> output = new List<string>();
            
            foreach (var file in files.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                output.Add(file.Key);
                
                foreach (var item in file.Value.OrderBy(x => x.Value))
                {
                    output.Add($"--{item.Key} - {item.Value}kb");
                }
            }

            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                ,"output.txt"), output);
        }
    }
}
