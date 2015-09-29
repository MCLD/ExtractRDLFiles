using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtractReports {
    class Program {
        private static readonly string pathChar = Path.DirectorySeparatorChar.ToString();
        private static readonly string outputDirectory = "RecoveredReports";

        static void Main(string[] args) {
            using(var context = new ReportServerContext()) {
                var reports = context.Catalogs
                                     .AsNoTracking()
                                     .Where(c => c.Content != null);

                foreach(var report in reports) {
                    string path = report.Path.Replace('/', Path.DirectorySeparatorChar);

                    if(path.StartsWith(pathChar)) {
                        path = path.Substring(1);
                    }

                    path = string.Format("{0}{1}{2}", outputDirectory, pathChar, path);

                    var directory = path.Substring(0, path.LastIndexOf(pathChar));

                    if(!Directory.Exists(directory)) {
                        Console.WriteLine("Creating directory: {0}", directory);
                        Directory.CreateDirectory(directory);
                    }

                    Console.WriteLine("Writing file: {0}.rdl", directory);
                    File.WriteAllText(string.Format("{0}.rdl", path),
                                      Encoding.Default.GetString(report.Content));
                }

                Console.WriteLine("Processed {0} reports.", reports.Count());
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            }
        }
    }
}
