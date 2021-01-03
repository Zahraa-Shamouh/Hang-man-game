using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //so we can get the text. 

public class GameController : MonoBehaviour
{
    public Text wordIndicator;    //how many words 
    public Text scoreIndicator;   // to follow up with the scoure
    public Text letterIndicator;  // indicator for the unmbers of letters


    private HangmanController hangman;  //hangmane reference 

    private string word;         //[word] which will be stord as string
    private char[] Revealed;     //for each time the word is set.
    private int score;
    private bool GameCompleted;

    // Start is called before the first frame update
    void Start()
    {

        //initilze 
       // hangman = GameObject.FindGameObjectsWithTag("player").GetComponent<HangmanController>(); 
        reset(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void next() { 
    }

    void reset()
    {
        //setting the scoure 
        score = 0;                //the initial value of the score!
        GameCompleted = false;    //game is not finish. 
        next();                   //call fuction in a function. 
    }
}
