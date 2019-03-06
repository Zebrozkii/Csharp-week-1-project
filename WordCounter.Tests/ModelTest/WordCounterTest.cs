using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

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
      CountWords test = new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,1);
    }
    [TestMethod]
    //
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
    [TestMethod]
    public void SingleLetterOneMatch()
    {
      string sentence="i";
      string word="i";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,1);
    }
    [TestMethod]
    public void SingleLetterDoesntMatch()
    {
      string sentence="t";
      string word="i";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,0);
    }
    [TestMethod]
    public void SingleLetterInWordDoesntMatch()
    {
      string sentence="Im jimmy";
      string word="i";
      CountWords test=new CountWords(word,sentence);
      int count=test.WordCount();
      Assert.AreEqual(count,0);
    }

    [TestMethod]
    public void ConstructorTest()
    {
      string sentence = "hi im jimmy";
      string word = "hi";
      CountWords test = new CountWords(word,sentence);
      string sentenceTest = test.UserSentence();
      string wordTest = test.UserWord();
      Assert.AreEqual(word, wordTest);
      Assert.AreEqual(sentence,sentenceTest);

    }
  }
}
