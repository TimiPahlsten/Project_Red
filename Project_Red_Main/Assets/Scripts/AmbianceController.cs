using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceController : MonoBehaviour
{

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = this.GetComponent<AudioSource>();
        audioSource.time = Random.Range(0, audioSource.clip.length);

        
    }

}
