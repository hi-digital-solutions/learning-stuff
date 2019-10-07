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
            var answer = new Answer(input);
            var expectedWords = answer.Words;

            expectedWords.Should().Be("Hello World");
        }
    }

}