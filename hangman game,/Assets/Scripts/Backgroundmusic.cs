using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Backgroundmusic : MonoBehaviour
{
    private AudioSource audioSource;
    private float volume = 1f; // modifird by the slider
    private static Backgroundmusic _instance;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    private void Update()
    {
        audioSource.volume = volume; 
    }


    public void SetVolume(float vol)
    {
        volume = vol; 
    }

    //for the background music to be ON in all scencs
    void Awake()
    {
        if (!_instance)
            _instance = this;
        else
            Destroy(this.gameObject); 
 
        DontDestroyOnLoad(this.gameObject);
    }


}
