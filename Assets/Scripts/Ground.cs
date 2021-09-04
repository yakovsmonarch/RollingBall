using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject _ground;
    [SerializeField] private float _speed = 10;

    private void Update()
    {
        _ground.transform.position = new Vector2((_ground.transform.position.x - (_speed * Time.deltaTime)), _ground.transform.position.y);
    }
}