using WordUnscrambler.Workers;
using Xunit;

namespace WordUnscrambler.Test.Unit
{
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [Fact]
        public void ScrambledWordMatchesGivenWordInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "omre" };

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.True(matchedWords.Count == 1);
            Assert.True(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.True(matchedWords[0].Word.Equals("more"));
        }

        [Fact]
        public void ScrambledWordMatchesGivenWordsInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "omre", "act" };

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.True(matchedWords.Count == 2);
            Assert.True(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.True(matchedWords[0].Word.Equals("more"));
            Assert.True(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.True(matchedWords[1].Word.Equals("cat"));
        }
    }
}
