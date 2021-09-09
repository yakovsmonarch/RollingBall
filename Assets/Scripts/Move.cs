using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Rigidbody2D _rigidbody;

    private float _jumpPower = 8f;
    private bool _isGrounded = true;

    private void Start()
    {
        Time.timeScale = 3f;
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    _rigidbody.AddForce(transform.up * _jumpPower, ForceMode2D.Impulse);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
