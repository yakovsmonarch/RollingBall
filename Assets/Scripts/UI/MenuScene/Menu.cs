using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _creatorsPanel;

    private int _menuScene = 0;
    private int _gameScene = 1;

    public void OnPlayButton()
    {
        SceneManager.LoadScene(_gameScene);
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

    public void OnOpenMenu()
    {
        SceneManager.LoadScene(_menuScene);
    }
}