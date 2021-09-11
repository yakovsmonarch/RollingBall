using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private Text _viewNumberHearts;

    private int _numberHearts = 0;

    private void OnEnable()
    {
        _playerMovement.TouchingHeart += AddHeart;
    }

    private void OnDisable()
    {
        _playerMovement.TouchingHeart -= AddHeart;
    }

    private void AddHeart()
    {
        _numberHearts++;
        _viewNumberHearts.text = _numberHearts.ToString();
    }
}
