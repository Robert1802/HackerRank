// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true

/*
     When a contiguous block of text is selected in a PDF viewer, the selection is highlighted with a blue rectangle.
     In this PDF viewer, each word is highlighted independently.
 
     There is a list of  character heights aligned by index to their letters.
     For example, 'a' is at index  and 'z' is at index .
     There will also be a string.
     Using the letter heights given, determine the area of the rectangle highlight in assuming all letters are  wide.
 */

static int designerPdfViewer(List<int> h, string word)
{
    List<string> alphabet = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

    List<int> letterIndexes = [];

    for (int i = 0; i < word.Length; i++)
    {
        letterIndexes.Add(alphabet.IndexOf(word[i].ToString()));
    }

    List<int> letterHeights = [];

    for (int j = 0; j < letterIndexes.Count(); j++)
    {
        letterHeights.Add(h[letterIndexes[j]]);
    }

    return word.Length * letterHeights.Max();

}


List<int> h = [1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7];
string word = "zaba";

Console.WriteLine(designerPdfViewer(h, word));