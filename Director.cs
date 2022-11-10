using System;

class Director
{ 
 
    bool keepPlaying = true;
    public void StartGame()
    {
        
        
        while (keepPlaying)
        {
            showJumper();
        }
    }
    
    public void showJumper()
    {
        Jumpeer jumper = new Jumpeer();
        jumper.createJumper();
    }
}
