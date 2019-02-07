using System;
using System.IO;
using Aspose.Words;
using System.Linq;

namespace WordBookmark {
    class Callback : IWarningCallback {
        public void Warning(WarningInfo info) {
            Console.WriteLine(info.Description);
        }
    }

    class Program {
        static void Main(string[] args) {
            var files = new DirectoryInfo("resource").GetFiles("*.doc*");
            foreach (var file in files) {
                Console.WriteLine("~ {0}", file.FullName);
                var doc = new Document(file.FullName);
                // doc.RemoveMacros();
                // doc.WarningCallback = new Callback();
                var marks = doc.Sections.SelectMany(x => x.Range.Bookmarks);

                foreach (var item in marks) {
                    Console.WriteLine("  > {0} ~~ {1}", item.Name, item.Text);
                }
                Console.WriteLine();
            }
        }
    }
}