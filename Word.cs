using System;

public class Word
{
    private string secretWord;
    private string hint;

    public string _word()
    {


        return secretWord;
    }



    public void CompareToGuess(string userGuess, string wordToGuess)
    {
        secretWord = wordToGuess;
        // string[] hint = null;

        
        // string[] splitword = wordToGuess.Split();
        // Console.Write(wordToGuess.Split());
        // Console.Write(secretWord.Length);
        for (int i = 0; i < secretWord.Length; i++)
        {
          if (secretWord[i]==Convert.ToChar(userGuess)){
                Console.Write($"{secretWord[i]}");
          }
          else{
            Console.Write("_");
          }
        }


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

