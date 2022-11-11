using System;
using System.Collections.Generic;


namespace Jumper
{
    class chosenWordList
    {
        
        private string[] listWords = { "Apple", "Mouse", "Index", "Dozen", "Union" };
        public List<string> getWordList(){

            List<string> wordsList = new List<string>(listWords);
            return wordsList;
            
        }
        public void GetWord()
        {
            var random = new Random();
            int index = random.Next(wordslist.Count);
            Console.WriteLine(wordslist[index]);
        }
    }
}

