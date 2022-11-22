using System;
using System.Collections.Generic;

class Listy
    {
        private string _wordChosen;
        private string[] listWords = { "rat", "mouse", "desk", "banana", "crocodile"};
        private List<string> getWordList(){

            List<string> wordsList = new List<string>(listWords);
            return wordsList;

            
        }
        public string GetWord()
        {
            List<string> _listy = getWordList();
            var random = new Random();
            int index = random.Next(_listy.Count);
            
            _wordChosen = _listy[index];
            return _wordChosen;
        }
    }


