using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangmanController : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject arms;
    public GameObject legs;


    private int tries;
   


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] parts = new GameObject[] { legs, arms, body, head };
        tries = parts.Length - 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
