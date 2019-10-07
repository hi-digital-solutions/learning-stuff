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
           
            var answer = new Answer("Hello World");
            var expectedWords = answer.Words;

            expectedWords.Should().Be("Hello World");
        }
    }

}