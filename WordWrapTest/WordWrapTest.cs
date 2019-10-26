using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class WordWrapTests
    {
        [Fact]
        public void GetEmptyLineOfText()
        {
            string input = "";
            int columnWidth = 15;
            string expected = "";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetOneLineOfText()
        {  
            string input = "Word wrapping!";
            int columnWidth = 15;
            string expected = "Word wrapping!";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
           public void GetOneLineOfTextWithTrailingWhiteSpace()
        {  
            string input = "   Word wrapping!   ";
            int columnWidth = 15;
            string expected = "Word wrapping!";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

    }

}