using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWordtrue()
    {
      IsWord testWord = new IsWord();
      Assert.AreEqual(false,testWord.IsWordtrue())

    }
  }
}
