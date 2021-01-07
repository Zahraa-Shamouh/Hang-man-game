using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public void Rate()
    {
        Application.OpenURL("market://details?id=com.test.testtest");
    }
    public void feedback()
    {
        Application.OpenURL("mailto:ZAHRAA.M.SHAMOUH@gmail.com"); 
    }
}
