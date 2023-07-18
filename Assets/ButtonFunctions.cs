using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

    public GameObject mainPage;
    public GameObject howToPlay;
    
    void Start() {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        mainPage.SetActive(true);
        howToPlay.SetActive(false);
    }

    public void Home() {
        SceneManager.LoadScene(0);
    }

    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void HowToPlay() {
        mainPage.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void BackToHome() {
        mainPage.SetActive(true);
        howToPlay.SetActive(false);
    }

}
