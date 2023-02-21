using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPublicAudio : MonoBehaviour
{

    public AudioSource source;
    public float delayTime;

    public bool delay;

    public void PlayAudio()
    {
        if(!delay)
        {
            source.Play();
        }

        if(delay)
        {
            StartCoroutine(DelayAudio());
        }

    }

    IEnumerator DelayAudio()
    {
        yield return new WaitForSeconds(delayTime);
        source.Play();
    }

}
