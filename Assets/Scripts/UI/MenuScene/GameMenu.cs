using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    private int _menuScene = 0;

    public void OnOpenMenu()
    {
        SceneManager.LoadScene(_menuScene);
    }
}
