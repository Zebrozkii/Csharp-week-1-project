using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]

    public void GetUserSentence()
    {
      string sentence="hello im jimmy";
      string word="jimmy";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,1);
    }
    [TestMethod]
  
    public void ZeroMatchedWords()
    {
      string sentence="hello im jimmy";
      string word="water";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,0);
    }
    [TestMethod]
    public void MakeSureCountWorks()
    {
      string sentence="hello im im im jimmy";
      string word="im";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,3);
    }
  }
}
