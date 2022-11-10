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
        

    }
    
    public void DoUpdates()
    {
        
       
     
    }
    public void DoOutputs()
    {
        
    }
}
