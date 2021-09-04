using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Move : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private AnimationClip _animationJump;


    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.Play(_animationJump.name);
        }
    }
}
