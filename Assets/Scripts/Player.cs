using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private Text _viewNumberHearts;

    private int _numberHearts = 0;

    private void OnEnable()
    {
        _playerMovement.TouchingHeart += AddHeart;
        _playerMovement.ClashWithEnemy += Damage;
    }

    private void OnDisable()
    {
        _playerMovement.TouchingHeart -= AddHeart;
        _playerMovement.ClashWithEnemy -= Damage;
    }

    private void AddHeart()
    {
        _numberHearts++;
        _viewNumberHearts.text = _numberHearts.ToString();
    }

    private void Damage()
    {
        _numberHearts--;
        _viewNumberHearts.text = _numberHearts.ToString();
        if(_numberHearts < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
