using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    private float _jumpPower = 8f;
    private bool _isGrounded = true;
    private float _speed = 2f;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isGrounded)
        {
            _rigidbody.AddForce(transform.up * _jumpPower, ForceMode2D.Impulse);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
        }
    }
}
