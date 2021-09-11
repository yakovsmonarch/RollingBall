using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _playerTransform;

    private float _waitingTime = 4;
    private float _currentTime = 0;

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if(_currentTime >= _waitingTime)
        {
            CrateEnemy();

            _waitingTime = Random.Range(3, 5);
            _currentTime = 0;
        }
    }

    private void CrateEnemy()
    {
        Instantiate(_template, new Vector3(_playerTransform.position.x + 10, _playerTransform.position.y, 0), Quaternion.identity);
    }
}