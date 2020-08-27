using System;
using System.IO;
using System.Xml.Serialization;

namespace CSharpMissingFileFinder
{
    class Program
    {
        static string _path { get; set; } = "";
        static string _projectPath { get; set; } = "";

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
            }

            var serilizer = new XmlSerializer(typeof(Project));
            var fileStream = File.OpenRead(_projectPath);
            var project = (Project)serilizer.Deserialize(fileStream);

            foreach (var group in project.ItemGroup)
            {
                foreach (var item in group.Reference)
                    if (item.HintPath != null 
                        && !item.HintPath.StartsWith(@"C:\")
                        && !File.Exists(Path.Combine(_path, item.HintPath))
                    )
                        Console.WriteLine(">> " + item.HintPath);

                foreach (var item in group.Compile)
                    if (!File.Exists(Path.Combine(_path, item.Include)))
                        Console.WriteLine(">> " + item.Include);

                foreach (var item in group.Content)
                {
                    if (!File.Exists(Path.Combine(_path, item.Include)))
                        Console.WriteLine(">> " + item.Include);
                }
            }
            Console.WriteLine("-".PadRight(20, '-'));
            Console.WriteLine("Finished");
        }
    }
}
