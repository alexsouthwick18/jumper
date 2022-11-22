using System;
using System.Collections.Generic;
public class Word
{
    private List<string> wordToGuess = new List<string>(); // crocodile
    private List<string> hint = new List<string>();       // _________

    public Word(string secretWord)
    {
      for(int j =0;j< secretWord.Length ; j++)
        {
            this.wordToGuess.Add(secretWord[j].ToString());
            hint.Add("_");
        }
    }

    public bool CompareToGuess(string userGuess)
    {
        // char empty = '_';

        bool hasGuessed = false;

        for (int i = 0; i < wordToGuess.Count; i++)
        {
          if (wordToGuess[i]==userGuess){
                 hint[i] = userGuess ;
                hasGuessed = true;
          }
          // }
          // else{
          //   Console.Write($"_ ");
          //   //charList.Insert(i,empty);
          //   charList[i] = empty;
          // }
          
        }
        for(int j =0;j< hint.Count ; j++)
        {
            Console.Write(hint[j]);
        }
            
        return hasGuessed;

    }

   
}

