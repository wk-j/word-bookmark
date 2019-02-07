using System;
using System.IO;
using Aspose.Words;
using System.Linq;

namespace WordBookmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("resource", "GitHub.doc");
            // var path = Path.Combine("resource", "GitHub.doc");
            var doc = new Document(path);
            var marks = doc.Range.Bookmarks;

            foreach (var item in marks)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Text);
                Console.WriteLine("--------");
            }
        }

    }
}
