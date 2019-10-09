using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class WordWrapTests
    {
        [Fact]
        public void GetOneLineOfText()
        {
            string input = "Hello World";
            int columnWidth = 11;
            string expected = "Hello World";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetTwoLinesofTextWithNoBreakWithinWords()
        {
            string input = "Hello there, this should result in at least two lines!";
            int columnWidth = 11;
            string expected = "Hello there\n, this should";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }


    }

}