using System.Collections.Generic;
using static System.Random;
using System.Text;
using System;
public class GetInputs
{



    //taking away each line for wrong guesses
    public static void wrongGuess(int wrong)
    {
        if(wrong == 0)
        {

        }
        else if (wrong == 1)
        {

        }
    }

    public static void printWord(List<char>guessedLetters, string randomWord)
    {
        // int counter = 0;
        int rightLetters = 0;
        Console.Write("\r\n");
        foreach (char c in randomWord)
        {
            if(guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters++;
            }
        }

    }

}
