using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private int _minTime;
    [SerializeField] private int _maxTime;
    [SerializeField] private float _liveTimeEnemy;

    private float _waitingTime;
    private float _currentTime = 0;
    private float _currentLiveTimeEnemy = 0;
    private List<GameObject> _enemies = new List<GameObject>();
    private int _currentIndexEnemy = 0;

    private void Start()
    {
        _waitingTime = Random.Range(_minTime, _maxTime);
        for (int i = 0; i < 10; i++)
        {
            _enemies.Add(Instantiate(_template, new Vector3(0, 0, 0), Quaternion.identity));
            _enemies[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        _currentLiveTimeEnemy += Time.deltaTime;

        if(_currentTime >= _waitingTime)
        {
            CrateEnemy(_currentIndexEnemy++);
            if(_currentIndexEnemy == _enemies.Count)
            {
                _currentIndexEnemy = 0;
            }

            _waitingTime = Random.Range(_minTime, _maxTime);
            _currentTime = 0;
        }

        if(_currentLiveTimeEnemy >= _liveTimeEnemy)
        {
            _currentLiveTimeEnemy = 0;
        }
    }

    private void CrateEnemy(int currentIndexEnemy)
    {
        _enemies[currentIndexEnemy].transform.position = new Vector3(_playerTransform.position.x + 10, _playerTransform.position.y, 0);
        _enemies[currentIndexEnemy].gameObject.SetActive(true);
    }
}