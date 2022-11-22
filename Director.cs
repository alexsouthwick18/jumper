using System;
using System.Collections.Generic;

class Director
{ 
    List<char> charsGuessed = new List<char>();
    string wordToGuess = "";
    bool keepPlaying = true;
    int attempts = 4;
    Word word = null;
        
    
    public void StartGame()
    {
        
        
        while (keepPlaying)
        {
            GameStart();
            while (attempts > 0)
            {   
                getInput();
            }
           
            gameOver();
        }
    }
    

    public void GameStart()
    {
        chosenWordList listy = new chosenWordList();
        wordToGuess = listy.GetWord();
        word = new Word(wordToGuess);

        Console.WriteLine($"word to guess: {wordToGuess}");
        listy.HideWord(wordToGuess);
        Console.WriteLine();
        BuildJummper(attempts);
       
    }
    public void getInput(){
        bool HasGuessed = false;
        string playerguess = "" ;
         
        Console.Write($"Guess a letter (a-z): ");
        playerguess = Console.ReadLine();
        if(playerguess.Length==1)
        {
            HasGuessed = word.CompareToGuess(playerguess);
        
            if (HasGuessed != true)
            {
                attempts--;
            }

            Console.WriteLine();
            Console.WriteLine();
            BuildJummper(attempts);

        }
    }
    private void BuildJummper(int attempts)
    {
        /// shows the jumper
        Jumpeer jumper = new Jumpeer();
        jumper.createJumper(attempts);
    }
    public void gameOver(){
        Console.WriteLine();
        Console.WriteLine($"Game Over :'( ");
        Console.WriteLine();
        keepPlaying = false;
    }

}
