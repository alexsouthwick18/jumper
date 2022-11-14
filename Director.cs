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
         /// get the word from the list and assign it to the goblal variable wordToGuess
        chosenWordList listy = new chosenWordList();
        wordToGuess = listy.GetWord();
        Console.WriteLine($"word to guess: {wordToGuess}");
        ///hide the characters of the word and print it
        listy.HideWord(wordToGuess);

        /// shows the jumper
        Jumpeer jumper = new Jumpeer();
        jumper.createJumper(attempts);
       
    }
    public void getInput(){
        Console.WriteLine("Guess a letter (a-z): ");
    }
    public void gameOver(){
        keepPlaying = false;
    }

}
