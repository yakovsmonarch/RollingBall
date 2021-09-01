using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        Debug.Log("Play");
    }

    public void OnCreatorsButton()
    {
        Debug.Log("Show creators");
    }

    public void OnExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
