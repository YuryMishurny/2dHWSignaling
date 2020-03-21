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
            transform.Translate(1 * _speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);
        }
    }
}
