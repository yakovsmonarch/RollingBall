using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpPower = 8f;
    [SerializeField] private float _speed = 5.0f;

    private bool _isGrounded = true;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0f, 0f);
        if (Input.GetMouseButtonDown(0) && _isGrounded)
        {
            _rigidbody.AddForce(new Vector2(0, _jumpPower), ForceMode2D.Impulse);
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
