using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _creatorsPanel;

    public void OnPlayButton()
    {
        Debug.Log("Play");
    }

    public void OnCreatorsButton()
    {
        _creatorsPanel.SetActive(true);
    }

    public void OnExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}