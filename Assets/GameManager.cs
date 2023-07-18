using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

   public float timeRemaining = 120;

   public Text timerText;

    void Update() {
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
            timerText.text = timeRemaining.ToString("0");
        } else if(timeRemaining <= 0) {
            SceneManager.LoadScene(2);
        }
    }
}
