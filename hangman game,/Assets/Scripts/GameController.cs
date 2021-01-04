using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //so we can get the text. 
using Util;  //import the Util class. 

public class GameController : MonoBehaviour
{
    public Text wordIndicator;    //to show the selected word.  
    public Text scoreIndicator;   // to follow up with the scoure
    public Text letterIndicator;  // how many letters i have in the word

    private HangmanController hangman;  //hangmane reference 

    private string word;         //[word] which will be stord as string
    private char[] Revealed;     //for each time the word is set.
    private int score;
    private bool GameCompleted;

    // Start is called before the first frame update
    void Start()
    {
        //initilze 
        hangman = GameObject.FindGameObjectWithTag("Player").GetComponent<HangmanController>(); 
        reset(); 
    }

    // Update is called once per frame
    void Update()
    {
        string s = Input.inputString;
        //one letter at a time
        if (s.Length == 1 && TextUtil.isLAlpha(s[0]))
        {

        }
    }
    private void updateWordIndicator()
    {
        string displayed = ""; 
        
        //build up the display string, hid the word and change each letter with '_' 
        for (int i=0; i<Revealed.Length; i++)
        {
            char c = Revealed[i]; 
            if (c == 0)
            {
                c = '_'; 
            }

            displayed += ' ';
            displayed += c; 
        }
        
        wordIndicator.text = displayed; //to display the _ for the word so the player can guess it. 
    }
    //to set the word 
    void SetwordIndicator(string word)
    {
        this.word = word;
        Revealed = new char[word.Length];
        letterIndicator.text = "" + word.Length; //# of letters, how long the letters is. 

        updateWordIndicator(); 
    }

    void next() {
        SetwordIndicator("zahraa"); 
    }

    void reset()
    {
        //setting the scoure 
        score = 0;                //the initial value of the score!
        GameCompleted = false;    //game is not finish. 
        next();                   //call fuction in a function. 
    }
}
