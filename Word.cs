using System;
using System.Collections.Generic;
public class Word
{
    private List<string> _wordToGuess = new List<string>(); // crocodile
    private List<string> _hint = new List<string>();       // _________
    private bool _hasWin = false;

    public Word(string secretWord)
    {
      for(int j =0;j< secretWord.Length ; j++)
        {
            this._wordToGuess.Add(secretWord[j].ToString());
            _hint.Add("_");
        }
    }

    public bool CompareToGuess(string userGuess)
    {

        bool hasGuessed = false;

        for (int i = 0; i < _wordToGuess.Count; i++)
        {
          if (_wordToGuess[i]==userGuess){
                 _hint[i] = userGuess ;
                hasGuessed = true;
          }
          
          
        }
        showHint();
        return hasGuessed;

    }

    public bool HasWin(){

        bool areEqual = true;
         for (int i = 0; i < _wordToGuess.Count; i++)
        {
             if(_wordToGuess[i] != _hint[i]){
                areEqual = false;
             }

        }
        _hasWin = areEqual;
        return _hasWin;
    }
    public void showHint(){
         for(int j =0;j< _hint.Count ; j++)
        {
            Console.Write($"{_hint[j]} ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }

   
}

