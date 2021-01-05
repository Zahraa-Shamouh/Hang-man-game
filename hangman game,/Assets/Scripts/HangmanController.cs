using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangmanController : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject Rightarm;
    public GameObject Leftarm;
    public GameObject Rightleg;
    public GameObject Leftleg;


    private int tries;
    GameObject[] parts;


    /*Property in C# is a member of a class that provides a flexible mechanism for classes to expose private fields.
     * property basically a reflection of this HangmanControlle. 
     */
    public bool isDead
    {
        get { return tries<0; }
    }


    // Start is called before the first frame update
    void Start()
    {   
        parts = new GameObject[] {Leftleg, Rightleg, Leftarm, Rightarm, body, head };
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void punish()
    {
        if (tries >= 0)
        {
            //make the hangman visible agin 
            parts[tries--].SetActive(true); 
        }
    }

    public void reset()
    {
        if (parts == null) //should be at the initially   
            return;


        tries = parts.Length - 1;

        //make the hangman invisible 
        foreach (GameObject man in parts)
        {
            man.SetActive(false); 
        }
    }
}
