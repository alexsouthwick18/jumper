using System;
public class Jumpeer
    {
        public Jumpeer(){

        }
        public void createJumper(int attempts)
        {
            if (attempts >= 4)
            {
                Console.WriteLine("  --- ");
            }

            if (attempts>=3)
            {
                Console.WriteLine(" /___\\");
            }

            if (attempts>=2){
                Console.WriteLine(" \\   /");
            }

            if (attempts>=1){
                Console.WriteLine("  \\ /");
                Console.WriteLine("   O  ");
                Console.WriteLine(" / | \\");                      
                Console.WriteLine(" /   \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            else{
                Console.WriteLine("   x  ");
                Console.WriteLine(" / | \\");                      
                Console.WriteLine(" /   \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            

        }

    }