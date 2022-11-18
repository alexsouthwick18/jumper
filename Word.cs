using System;

    public class Word
    {
       private string secretWord; 
       private string hint; 

        public string _word()
        {


            return secretWord;
        }

        public void CompareToGuess(string w)
        {  
            // string hint = "_";
            // int attempts = 4;  

            // while(attempts > 0)
            // {
            //     if('Z'.CompareTo('Z') == 0)
            //         Console.WriteLine("Same character !");
            //     if (guess == secretWord)
            // }
        }
        public string GetHint()
        {
            return hint;
        }
        public bool Guessed()
        {
            return(hint == secretWord);
        }
    }

