using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public float fadeTime;
    private float targetVolume;

    public float audioOn;
    public float audioOff;

    private void Start()
    {
        targetVolume = audioOn;
    }

    void Update()
    {
        audioSource.volume = Mathf.MoveTowards(audioSource.volume, targetVolume, (1.0f / fadeTime) * Time.deltaTime);
    }

    void FadeOut()
    {
        targetVolume = audioOff;
    }


    void FadeIn()
    {
        targetVolume = audioOn;
    }

}
