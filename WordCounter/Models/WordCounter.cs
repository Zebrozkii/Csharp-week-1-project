using System.Collections.Generic;

namespace WordCounter
{
  public class CountWords
  {
    private string _userInputWord;
    private string _userInputSentence;

    public CountWords( string word, string sentence){
      _userInputWord = word;
      _userInputSentence = sentence;
    }
    public string UserSentence(){

      return _userInputSentence;

    }
    public string UserWord(){
      return _userInputWord;
    }
    public int WordCount(){
      int wordCount=0;
      string[] sentenceSplit=_userInputSentence.Split(' ');
      foreach(string x in sentenceSplit)
      {
        if(x==_userInputWord)
        {
          wordCount++;
        }
      }
      return wordCount;
    }

  }
}
