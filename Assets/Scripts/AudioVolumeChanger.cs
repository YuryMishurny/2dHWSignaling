using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    void Update()
    {
        ChangeVolume();
    }

    private void ChangeVolume()
    {
        _audio.volume = Mathf.Sin(Time.time*3);
    }
}
