using System;

class Director
{ 
 
    bool keepPlaying = true;
    int attempts = 4;
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
        jumper.createJumper(attempts);
    }
    public void getInput(){
        Console.WriteLine("Guess a letter (a-z): ");
    }
    public void gameOver(){
        keepPlaying = false;
    }

}
