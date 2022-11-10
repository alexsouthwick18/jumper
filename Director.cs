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
        Console.WriteLine("Guess a letter [A-Z]: ");
        Console.ReadKey();
        
    }
    
    public void DoUpdates()
    {
        
       
     
    }
    public void DoOutputs()
    {
        
    }
}
