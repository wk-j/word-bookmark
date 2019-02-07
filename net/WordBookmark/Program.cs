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
            var path = Path.Combine("resource", "Bookmark.doc");
            // var path = Path.Combine("resource", "GitHub.doc");
            var doc = new Document(path);
            // var marks = doc.Range.Bookmarks;

            doc.RemoveMacros();
            doc.WarningCallback = new Callback();

            var marks = doc.Sections.SelectMany(x => x.Range.Bookmarks);

            foreach (var item in marks) {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Text);
                Console.WriteLine("--------");
            }
        }
    }
}