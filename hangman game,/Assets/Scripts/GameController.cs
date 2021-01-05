using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //so we can get the text. 
using Util;            //import the Util class. 

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
        //move to the next word; 
        if (GameCompleted)
        {
            string tmp = Input.inputString; 
            if (Input.anyKeyDown)
                next();
            return; 
        }

       // if (! Input.anyKeyDown)
       //     return; 


        string s = Input.inputString;
        //one letter at a time
        if (s.Length == 1 && TextUtil.isLAlpha(s[0]))
        {
            Debug.Log("Have " + s);

            //chech to player failure. 
            if (!check(s.ToUpper()[0]))
            {
                hangman.punish(); //punish is a method to be called whenever the player lose. 

                if (hangman.isDead)
                {
                    //show the word to the player 
                    wordIndicator.text = word; 
                    GameCompleted = true; //Gameover her !!
                }
            }
        }
    }

    private bool check (char c)
    {
        bool checks = false; // by defult we fail the check 
        int complete = 0; 
        int score = 0; //initialze score value to zero. 

        for (int i = 0; i < Revealed.Length; i++)
        {
            //we have a blank spot then we want to increment the score 
            if (c == word[i])
            {
                checks = true; 
                if (Revealed[i] == 0)
                {
                    Revealed[i] = c;
                    score++; 
                }
            }

            if (Revealed[i] != 0)
            {
                complete++; 
            }

        }

        //score manipulation 
        if (score != 0)
        {
            this.score += score; 
            if (complete == Revealed.Length)
            {
                this.GameCompleted = true; 
                this.score += Revealed.Length; 
            }
            updateWordIndicator(); 
            updatescoreIndicator(); 
        }

        return checks; 

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


    private void updatescoreIndicator()
    {
        scoreIndicator.text = "Your Score: " + score; 
    }



    //to set the word 
    void SetwordIndicator(string word)
    {
        word = word.ToUpper(); 
        this.word = word;
        Revealed = new char[word.Length];
        letterIndicator.text = "Number of Letters: " + word.Length; //# of letters, how long the letters is. 
        updateWordIndicator(); 
    }

    public void next() {
        hangman.reset();          // call it from the HangmanController.cs
        GameCompleted = false;
        SetwordIndicator(WordBank.instance.next(0)); 
    }

    public void reset()
    {
        //setting the scoure 
        score = 0;                //the initial value of the score!
        //GameCompleted = false;    //game is not finish. 
       
        //GameCompleted = false; 
        updatescoreIndicator();   // get the score. 
        next();                   //call fuction in a function. 
    }
}
