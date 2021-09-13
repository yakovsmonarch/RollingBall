using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wictory : MonoBehaviour
{
    public event UnityAction FinishWictory;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Player player))
        {
            FinishWictory?.Invoke();
        }
    }
}
  