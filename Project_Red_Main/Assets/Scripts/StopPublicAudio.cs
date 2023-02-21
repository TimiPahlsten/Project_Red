using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPublicAudio : MonoBehaviour
{

    public AudioSource source;

    public bool delay;

    public void PlayAudio()
    {
        if(!delay)
        {
            source.Stop();
        }

        if(delay)
        {
            StartCoroutine(DelayAudio());
        }

    }

    IEnumerator DelayAudio()
    {
        yield return new WaitForSeconds(4);
        source.Stop();
    }

}
