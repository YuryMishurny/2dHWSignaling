using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private Color _targetColor;
    [SerializeField] private AudioSource _audio;

    private void Update()
    {
        ChangeVolume();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MoveThief>(out MoveThief moveThief))
        {
            _renderer.color = _targetColor;
            _audio.Play();           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _renderer.color = _color;
        _audio.Stop();
    }
    private void ChangeVolume()
    {
        _audio.volume = Mathf.Sin(Time.time * 3);
    }
}
