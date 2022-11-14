using System;
using System.Collections.Generic;


namespace Jumper
{
    class chosenWordList
    {
        
        private string[] listWords = { "apple", "mouse", "index", "dozen", "union" };
        public List<string> getWordList(){

            List<string> wordsList = new List<string>(listWords);
            return wordsList;

            
        }
        public void GetWord()
        {
            List<string> listy = getWordList();
            var random = new Random();
            int index = random.Next(listy.Count);
            Console.WriteLine(listy[index]);
        }
    }
}

