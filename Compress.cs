using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompressionTask
{
    public class Compress
    {
        public string CompressString(string word)
        {

            var count = 0;
            var wordsLetter = word[0];

            var compression = "";


            foreach (var letter in word)
            {
                if (letter == wordsLetter)
                {
                    count++;
                }
                else
                {
                    compression += wordsLetter.ToString() + count;
                    wordsLetter = letter;
                    count = 1;

                }
            }

            compression += wordsLetter.ToString() + count;

            return compression;
        }
    }
}
