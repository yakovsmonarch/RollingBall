using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Rigidbody2D _rigidBody;
    private float _tapForce = 400f;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = Vector2.zero;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidBody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }
    }
}
