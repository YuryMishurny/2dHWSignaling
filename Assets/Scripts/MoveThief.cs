using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThief : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Movement(1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement(-1);
        }
    }

    private void Movement(float directionX)
    {
        transform.Translate(directionX * _speed * Time.deltaTime, 0, 0);
    }
}