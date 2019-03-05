using System.Collections.Generic;
using WordCounter;

namespace  WordCounter.Models
{
  public class CountWords
  {
    private string _userInputWord;
    // private int _id;
    private string _userInputSentence;
    private static List<CountWords> _instances = new List<CountWords>{};

    public CountWords( string word, string sentence){
      _userInputWord = word;
      _userInputSentence = sentence;
      _instances.Add(this);
    }
    public string UserSentence(){

      return _userInputSentence;

    }
    public string UserWord(){
      return _userInputWord;
    }

    public static List<CountWords> GetAll()
    {
      return _instances;
    }
    // public int GetId()
    // {
    //   return _id;
    // }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    //
    // public static CountWords Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

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
