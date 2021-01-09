using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageToPlayer : MonoBehaviour
{
    public GameObject text;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            text.SetActive(false);
    }
}
