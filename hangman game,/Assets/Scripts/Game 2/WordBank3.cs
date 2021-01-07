using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace Util
{
    public class WordBank3
    {
        private static WordBank3 S_instance;
        private string[] words;

        public static WordBank3 instance
        {
            //if s_instance == null then return load() otherwise s_instance
            get { return S_instance == null ? load() : S_instance; }
        }
        private WordBank3(string[] words)
        {
            this.words = words;
        }
        private static bool isWordOK(string word)
        {
            if (word.Length < 1) // we can not have plank word. 
                return false;
            foreach (char c in word)
            {
                if (!TextUtil.isAlpha(c))
                    return false;
            }

            return true;
        }

        public static WordBank3 load()
        {
            //to avoid load everytime the WordBank is requisted 
            if (S_instance != null)
                return S_instance;

            //create a place for our words to go. 
            HashSet<string> wordList = new HashSet<string>();

            //loaded the wordlist 
            TextAsset asset = Resources.Load("sports") as TextAsset; //---------
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
            S_instance = new WordBank3(words);
            return S_instance;
        }
        public string next(int limit)
        {
            //select a random word
            int index = (int)(Random.value * (words.Length - 1));
            return words[index];
        }
    }
}