using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorTemplate : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private int _minTime;
    [SerializeField] private int _maxTime;
    [SerializeField] private float _liveTimeEnemy;
    [SerializeField] private float _height;

    private float _waitingTime;
    private float _currentTime = 0;
    private float _currentLiveTimeTemplate = 0;
    private List<GameObject> _templates = new List<GameObject>();
    private int _currentIndexTemplate = 0;

    private void Start()
    {
        _waitingTime = Random.Range(_minTime, _maxTime);
        for (int i = 0; i < 5; i++)
        {
            _templates.Add(Instantiate(_template, new Vector3(0, 0, 0), Quaternion.identity));
            _templates[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        _currentLiveTimeTemplate += Time.deltaTime;

        if(_currentTime >= _waitingTime)
        {
            CrateEnemy(_currentIndexTemplate++);
            if(_currentIndexTemplate == _templates.Count)
            {
                _currentIndexTemplate = 0;
            }

            _waitingTime = Random.Range(_minTime, _maxTime);
            _currentTime = 0;
        }

        if(_currentLiveTimeTemplate >= _liveTimeEnemy)
        {
            _currentLiveTimeTemplate = 0;
        }
    }

    private void CrateEnemy(int currentIndexEnemy)
    {
        _templates[currentIndexEnemy].transform.position = new Vector3(_playerTransform.position.x + 10, _height, 0);
        _templates[currentIndexEnemy].gameObject.SetActive(true);
    }
}