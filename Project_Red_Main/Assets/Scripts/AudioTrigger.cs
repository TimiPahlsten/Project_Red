using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(clip);
            this.gameObject.SetActive(false);
        }
    }
}
