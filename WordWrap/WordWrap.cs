using System;
using System.Collections.Generic;
using System.Linq;


namespace WordWrap
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
    public class Answer
    {

        public string Words;

        public Answer(string words, int columnWidth)
        {
            this.Words = GetAnswer(words, columnWidth);
        }

        private string GetAnswer(string words, int columnWidth)
        {
            var inputWords = words.Trim();
            if (inputWords.Length <= columnWidth)
            {
                return inputWords;
            }
            return "";

        }


    }
}
