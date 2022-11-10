using System;

<<<<<<< HEAD
namespace Jumper
{
    class Director
    {
        public Director()
        {
            Director director = new Director();
            
        }
    }
}
=======

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
>>>>>>> 52af7814c8da22c71485e58129dbb1a437066f43
