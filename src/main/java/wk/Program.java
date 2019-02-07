package wk;

import com.aspose.words.Bookmark;
import com.aspose.words.BookmarkCollection;
import com.aspose.words.Document;

public class Program {
    public static void main(String[] args) throws Exception {
        Document document = new Document("resource/Bookmark.doc");
        BookmarkCollection bookmarks = document.getRange().getBookmarks();

        for (Bookmark item : bookmarks) {
            System.out.println(item.getName());
            System.out.println(item.getText());
            System.out.println("-------------");
        }
    }
}