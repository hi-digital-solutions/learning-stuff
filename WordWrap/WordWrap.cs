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
            else if (inputWords.Length <= columnWidth *2)
            {
                var answerbuilder = new List<string>();
                int columnState = columnWidth;
                string answer;
                foreach(var word in inputWords.Split(" "))
                {
                    if( word.Length <= columnState)
                    {
                        answerbuilder.Add($" {word}");
                        columnState -= word.Length + 1;
                    }
                    else
                    {
                        answerbuilder.Add($"\n{word}");
                        columnState = columnWidth;
                    }
                }
                return answer = string.Join("", answerbuilder).Trim();
            }
            return "";

        }


    }
}
