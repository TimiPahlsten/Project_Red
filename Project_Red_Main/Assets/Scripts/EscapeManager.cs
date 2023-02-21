using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeManager : MonoBehaviour
{
    public Animator anim;
    public GameObject set1;
    public GameObject set2;

    public GameObject debree;

    bool used = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && !used)
        {
            StartCoroutine(ActivatePlayer());
            FindObjectOfType<AudioManager>().Play("Break");
            used = true;
        }
    }
    


    IEnumerator ActivatePlayer()
    {
        Debug.Log("Fell");
        anim.Play("BlackCut");
        set1.SetActive(false);
        
        
        yield return new WaitForSeconds(1);

        debree.SetActive(true);
        set2.SetActive(true);
    }
}
