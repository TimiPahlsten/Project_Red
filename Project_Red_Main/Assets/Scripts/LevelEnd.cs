using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    public void ReturnToMenu()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(12);

        SceneManager.LoadScene("Menu");
    }

}
