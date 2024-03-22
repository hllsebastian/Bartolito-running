using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource MusicSource, fxSound;
    //[SerializeField] private AudioClip audioPlay;
    private float volumeSound = 1f;

    public void GeneralSound(AudioClip audioClip)
    {
        fxSound.PlayOneShot(audioClip, volumeSound);
    }
}
