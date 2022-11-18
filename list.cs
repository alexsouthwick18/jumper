using System;
using System.Collections.Generic;

class chosenWordList
    {
        
        private string[] listWords = { "rat", "mouse", "desk", "banana", "crocodile"};
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
            // Console.WriteLine(wordChosen);
            return wordChosen;
        }

        public void HideWord(string word)
        {
            for(int i=1; i<=word.Length; i++ ){
                 Console.Write($"_ ");
            }
            Console.WriteLine("");
        }
    }


