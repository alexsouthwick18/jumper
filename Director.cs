using System;

class Director
{ 
    
    string wordToGuess = "";
    bool keepPlaying = true;
    int attempts = 4;
    public void StartGame()
    {
        
        
        while (keepPlaying)
        {
            gameDisplay();
            getInput();
            gameOver();
        }
    }
    
    public void gameDisplay()
    {
        Jumpeer jumper = new Jumpeer();
        jumper.createJumper(attempts);
        /// get the word from the list and assign it to the goblal variable wordToGuess
        chosenWordList listy = new chosenWordList();
        wordToGuess = listy.GetWord();
        Console.WriteLine(wordToGuess);
    }
    public void getInput(){
        Console.WriteLine("Guess a letter (a-z): ");
    }
    public void gameOver(){
        keepPlaying = false;
    }

}
