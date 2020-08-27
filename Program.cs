using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Serialization;

namespace CSharpMissingFileFinder
{
    class Program
    {
        static string _path { get; set; } = "";
        static string _projectPath { get; set; } = "";
        static string[] _gitignoreLines { get; set; } = new string[0];

        static void Main(string[] args)
        {
            while (_path == "")
            {
                Console.Write("Please enter the file path of the project: ");
                var input = Console.ReadLine().Replace("\"", "");
                if (!input.Contains(".csproj"))
                {
                    Console.WriteLine(">> Not a project file");
                    continue;
                }

                var projectFileInfo = new FileInfo(input);
                if (!projectFileInfo.Exists)
                {
                    Console.WriteLine(">> File Doesn't exist");
                    continue;
                }

                _path = projectFileInfo.Directory.FullName;
                _projectPath = projectFileInfo.FullName;
                
                var gitLocation = projectFileInfo.Directory.GetFiles()
                    .FirstOrDefault(file => file.Name == ".gitignore");

                if (gitLocation.Exists)
                    _gitignoreLines = File
                        .ReadAllLines(gitLocation.FullName)
                        .Where(line 
                            => line != "" 
                            && !line.StartsWith("#"))
                        .ToArray();
            }

            var serilizer = new XmlSerializer(typeof(Project));
            var fileStream = File.OpenRead(_projectPath);
            var project = (Project)serilizer.Deserialize(fileStream);

            foreach (var group in project.ItemGroup)
            {
                foreach (var item in group.Reference)
                    TestFile(item.HintPath);

                foreach (var item in group.Compile)
                    TestFile(item.Include);

                foreach (var item in group.Content)
                    TestFile(item.Include);
            }

            Console.WriteLine("-".PadRight(20, '-'));
            Console.WriteLine("Finished");
        }

        static string GetPath(string hintPath) => Path.Combine(_path, HttpUtility.UrlDecode(hintPath));

        static void TestFile (string relativeFilePath) {
            if (relativeFilePath == null || relativeFilePath.StartsWith(@"C:\")) 
                return;

            var fullPath = GetPath(relativeFilePath);

            if (File.Exists(fullPath)) {
                var isIgnored = _gitignoreLines.Any(line => relativeFilePath.Contains(line));
                if (isIgnored) {
                    WriteIgnored(relativeFilePath);
                    return;
                }
                //WriteFound(relativeFilePath);
                return;
            }

            WriteMissing(relativeFilePath);
        }

        static void WriteResult(string content, ConsoleColor colour) {
            var previousColour = Console.ForegroundColor;
            Console.ForegroundColor = colour;
            Console.WriteLine(content);
            Console.ForegroundColor = previousColour;
        }

        static void WriteFound(string path) => WriteResult($"[FOUND] {path}", ConsoleColor.Green);
        static void WriteMissing(string path) => WriteResult($"[MISSING] {path}", ConsoleColor.Red);
        static void WriteIgnored(string path) => WriteResult($"[IGNORED] {path}", ConsoleColor.Yellow);
    }
}
