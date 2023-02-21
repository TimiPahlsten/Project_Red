using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioZone : MonoBehaviour
{
    public AudioSource audioSource;
    public float fadeTime;
    private float targetVolume;

    public float maxAudio;
    public float minAudio;


    void Update()
    {
        audioSource.volume = Mathf.MoveTowards(audioSource.volume, targetVolume, (1.0f / fadeTime) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            targetVolume = maxAudio;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            targetVolume = minAudio;
}
}
