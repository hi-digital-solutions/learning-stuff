using System;


namespace WordWrap
{
    public class Answer
    {

        public string Words;

        public Answer(string words, int columnWidth)
        {
            this.Words = GetAnswer(words, columnWidth);
        }

        private string GetAnswer(string words, int columnWidth)
        {
            if (words.Length <= columnWidth)
            {
                return words;
            }
            else if (words.Length <= columnWidth * 2)//columnWith Index grow by 1 with each line
            {
                int index = 0;
                string wordFirstLine = words.Substring(0, columnWidth);
                string nextLine = "\n" + words.Substring(index += columnWidth, columnWidth);
                return wordFirstLine + nextLine;
            }
            else if (words.Length <= columnWidth * 3)
            {
                int index = 0;
                string wordFirstLine = words.Substring(0, columnWidth);
                index += columnWidth;
                string nextLine = "\n" + words.Substring(index, columnWidth);
                index += columnWidth; //line split index grows by the columnWith with each line
                string nextNextLine = "\n" + words.Substring(index, columnWidth);
                return wordFirstLine + nextLine + nextNextLine;
            }
            else
            {
                int index = 0;
                string wordFirstLine = words.Substring(0, columnWidth);
                index += columnWidth;
                string nextLine = "\n" + words.Substring(index, columnWidth);
                index += columnWidth;
                string nextNextLine = "\n" + words.Substring(index, columnWidth);
                index += columnWidth;
                string nextNextNextLine = "\n" + words.Substring(index, columnWidth);
                return wordFirstLine + nextLine + nextNextLine + nextNextNextLine;
            }

        }


    }
}
