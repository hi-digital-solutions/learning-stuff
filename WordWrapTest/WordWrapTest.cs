using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class WordWrapTests
    {
        [Fact]
        public void GetFirstLineOfText()
        {
            string input = "Hello World, this is the answer to everything!";
            int columnWidth = 11;
            var answer = new Answer(input,columnWidth);
            var expectedWords = answer.Words;

            expectedWords.Should().Be("Hello World");
        }

     
    }

}