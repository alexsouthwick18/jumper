using System;
using System.Collections.Generic;

class Director
{ 
 
    bool keepPlaying = true;
    public void StartGame()
    {
        
        
        while (keepPlaying)
        {
            showJumper();
            getInput();
            gameOver();
        }
    }
    
    public void showJumper()
    {
        Jumpeer jumper = new Jumpeer();
        jumper.createJumper();
    }
    public void getInput(){
        Console.WriteLine("Guess a letter (a-z): ");
    }
    public void gameOver(){
        keepPlaying = false;
    }

}
