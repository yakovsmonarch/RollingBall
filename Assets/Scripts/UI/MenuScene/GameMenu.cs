using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private Wictory _wictory;
    [SerializeField] private GameObject _wictoryPanel;

    private int _menuScene = 0;

    public void OnOpenMenu()
    {
        SceneManager.LoadScene(_menuScene);
    }

    private void OnEnable()
    {
        _wictory.FinishWictory += OpenWictoryPanel;
    }

    private void OnDisable()
    {
        _wictory.FinishWictory -= OpenWictoryPanel;
    }

    private void OpenWictoryPanel()
    {
        _wictoryPanel.gameObject.SetActive(true);
    }
}
