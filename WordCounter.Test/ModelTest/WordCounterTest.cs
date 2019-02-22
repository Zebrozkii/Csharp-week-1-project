using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsUserInputString()
    {
      string testWord="hello";
      string testSentence="My name is jimmy";
      CountWords testWordCount = new CountWords();
       Assert.AreEqual(true, testWordCount.WordCounter(testWord));

    }
  }
}
