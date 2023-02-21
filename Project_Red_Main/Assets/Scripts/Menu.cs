using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator cameraAnim;
    public Animator doorAnim;
    public Animator canvasAnim;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        StartCoroutine(PlayButton());
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator PlayButton()
    {
        FindObjectOfType<AudioManager>().Play("ButtonCong");

        yield return new WaitForSeconds(1);

        cameraAnim.Play("Camera_MoveIn");
        doorAnim.Play("DoorOpen");
        canvasAnim.Play("MenuFade");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("SampleScene");

    }

}
