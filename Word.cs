using System;

public class Word
{
    private string secretWord;
    private string hint;

    public string _word()
    {


        return secretWord;
    }



    public bool CompareToGuess(string userGuess, string wordToGuess)
    {
        secretWord = wordToGuess;
        // string[] hint = null;

        bool hasGuessed = false;
        
        // string[] splitword = wordToGuess.Split();
        // Console.Write(wordToGuess.Split());
        // Console.Write(secretWord.Length);
        for (int i = 0; i < secretWord.Length; i++)
        {
          if (secretWord[i]==Convert.ToChar(userGuess)){
                Console.Write($"{secretWord[i]}");
                hasGuessed = true;
          }
          else{
            Console.Write("_");
          }
          
        }
            return hasGuessed;

    }
    public string GetHint()
    {
        return hint;
    }
    public bool Guessed()
    {
        return (hint == secretWord);
    }
}

