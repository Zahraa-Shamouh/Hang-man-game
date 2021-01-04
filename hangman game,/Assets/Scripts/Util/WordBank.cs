using System.IO;
using System.Collections.Generic;
using UnityEngine; 

namespace Util
{
    public class WordBank{
        private static WordBank s_instance;
        private string[] words; 

        public static WordBank instance
        {
            //if s_instance == null then return load() otherwise s_instance
            get { return s_instance == null ? load() : s_instance;  }
        }
        private WordBank(string [] words){
            this.words = words; 
        }
        private static bool isWordOK(string word){
            if (word.Length < 1) // we can not have plank word. 
                return false; 
            foreach (char c in word)
            {
                if (!TextUtil.isAlpha(c))
                    return false; 
            }

            return true; 
        }

        public static WordBank load(){
            //to avoid load everytime the WordBank is requisted 
            if (s_instance != null)
                return s_instance; 


            //create a place for our words to go. 
            HashSet<string> wordList = new HashSet<string>();

            //loaded the wordlist 
            TextAsset asset = Resources.Load("words") as TextAsset;
            TextReader reader = new StringReader(asset.text); 

            //read all the lines 
            while (reader.Peek() != -1) // -1 return whenever the end of the stream is reached (whenever no text is available). 
            {
                string word = reader.ReadLine();  //read one line at a time. 

                if (isWordOK(word))
                    wordList.Add(word); 
            }
            //unload the wordlist. 
            Resources.UnloadAsset(asset);   

            //set up the wordBank 
            string[] words = new string[wordList.Count];
            wordList.CopyTo(words); 
            s_instance = new WordBank(words);
            return s_instance; 
        }
        public string next(int limit)
        {
            //random word
            int index = (int) (Random.value * (words.Length -1)); 
            return words[index]; 
        }
    }
}