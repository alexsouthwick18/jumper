using System;

class Director
{ 
 
    bool keepPlaying = true;
    public void StartGame()
    {
        
        
        while (keepPlaying)
        {
            
            GetInputs();
            DoUpdates();
            DoOutputs();
        }
    }
  

    public void GetInputs()
    {      
        Console.WriteLine(Jumper);

        Console.ReadKey("Guess a letter [A-Z]");

        String list = new list();
        

    }
    
    public void DoUpdates()
    {
        
       
     
    }
    public void DoOutputs()
    {
        
    }
}
