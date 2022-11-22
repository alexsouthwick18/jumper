using System;
using System.Collections.Generic;

class Director
{ 
    private bool _HasWin = false;
    private string wordToGuess = "";
    bool keepPlaying = true;
    int attempts = 4;
    Word word = null;
    Jumpeer jumper = new Jumpeer();
    Listy listy = new Listy();
        
    
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

        wordToGuess = listy.GetWord();
        word = new Word(wordToGuess);

        Console.WriteLine($"word to guess: {wordToGuess}");
        word.showHint(); // - - - - - -
        jumper.createJumper(attempts);
       
    }
    public void getInput()
    {
        
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
            jumper.createJumper(attempts);
        }

        this._HasWin = word.HasWin();
        if(this._HasWin)
        {
            attempts = 0;
        }

    }
    public void gameOver(){

        if(this._HasWin)
        {
            Console.WriteLine($"\nYou guessed the word!!! :D \n");
        }
        else{
            Console.WriteLine($"\nGame Over :'( \n");
            
        }
        keepPlaying = false;
    }

}
