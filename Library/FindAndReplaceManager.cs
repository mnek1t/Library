using System;
using Library;
namespace Library_Myextentions
{
    static class FindAndReplaceManager
    {
        public static void FindNext(this Book book, string _content)
        {
            if (_content == "" || _content == null)
            {
                Console.WriteLine("\nYou fetched empty string, so we format it to space button");
                _content = " ";
            }
            int index = KMPSearch(book,_content);

            if (index != -1)
            {
                Console.WriteLine($"\nPattern '{_content}' found in the text:");
                PrintTextWithHighlightedPattern(book, _content, index);
            }
            else
            {
                Console.WriteLine($"\nPattern '{_content}' not found in the text.");
            }
        }
        //Realization of KMP_ALGORITHM
        private static int[] ComputePrefixFunction(this Book book, string pattern) //calculate the prefic where pattern was found
        {
            int patternLength = pattern.Length;
            int[] prefixFunction = new int[patternLength];
            int j = 0;

            for (int i = 1; i < patternLength; i++)
            {
                while (j > 0 && pattern[i] != pattern[j])
                {
                    j = prefixFunction[j - 1];
                }

                if (pattern[i] == pattern[j])
                {
                    j++;
                }

                prefixFunction[i] = j;
            }

            return prefixFunction;
        }

        private static int KMPSearch(this Book book, string pattern)
        {
            string text = book.GetContent();
            int textLength = text.Length;
            int patternLength = pattern.Length;
            int[] prefixFunction = ComputePrefixFunction(book, pattern);
            int j = 0;
            for (int i = 0; i < textLength; i++)
            {
                while (j > 0 && text[i] != pattern[j])
                {
                    j = prefixFunction[j - 1];
                }

                if (text[i] == pattern[j])
                {
                    j++;
                }

                if (j == patternLength)
                {
                    return i - j + 1;

                }  
            }
            return -1;
        }
        private static void PrintTextWithHighlightedPattern(this Book book, string pattern, int patternIndex) // split actual content in first index of found pattern
        {
            string text = book.GetContent();
            Console.Write(text.Substring(0, patternIndex));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text.Substring(patternIndex, pattern.Length));
            Console.ResetColor();

            Console.Write(text.Substring(patternIndex + pattern.Length));
        }
    }
}
