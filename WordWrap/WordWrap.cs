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
            if (words.Trim().Length <= columnWidth)
            {
                return words.Trim();
            }
            else
            {
                var answerbuilder = new List<string>();
                int columnState = columnWidth;
               
                foreach(string word in words.Trim().Split(" "))
                {
                    if( word.Length <= columnState -1 && columnState > 0)
                    {
                        answerbuilder.Add($" {word}");
                        columnState -= word.Length + 1;
                    }
                    else
                    {
                        answerbuilder.Add($"\n{word}");
                        columnState = columnWidth;
                        columnState -= word.Length + 1;
                    }
                }
                return string.Join("", answerbuilder).Trim();
            }
        }


    }
}
