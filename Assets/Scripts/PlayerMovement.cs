using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _speed;
    [SerializeField] private float _timeScale;

    public event UnityAction TouchingHeart;
    public event UnityAction ClashWithEnemy;

    private bool _isGrounded = true;
    private bool _jump = false;

    private void Start()
    {
        Time.timeScale = _timeScale;
        StartCoroutine(SpeedUpPlayer());
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && _isGrounded)
        {
            _jump = true;
        }
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
        }

        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            ClashWithEnemy?.Invoke();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Heart heart))
        {
            TouchingHeart?.Invoke();
            collision.gameObject.SetActive(false);
        }
    }

    private void Move()
    {
        if (_isGrounded)
        {
            _rigidbody.velocity = new Vector2(_speed, 0);
        }
    }

    private void Jump()
    {
        if (_jump)
        {
            _rigidbody.AddForce(new Vector2(0, _jumpPower), ForceMode2D.Impulse);
            _isGrounded = false;
            _jump = false;
        }
    }

    private IEnumerator SpeedUpPlayer()
    {
        while (true)
        {
            _speed += 0.1f;
            yield return new WaitForSeconds(5f);
        }
    }
}