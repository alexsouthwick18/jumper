using System;
using System.Collections.Generic;

class chosenWordList
    {
        
        private string[] listWords = { "apple", "mouse", "index", "dozen", "union" };
        public List<string> getWordList(){

            List<string> wordsList = new List<string>(listWords);
            return wordsList;

            
        }
        public string GetWord()
        {
            List<string> listy = getWordList();
            var random = new Random();
            int index = random.Next(listy.Count);
            string wordChosen = listy[index];
            Console.WriteLine(wordChosen);
            return wordChosen;
        }
    }


