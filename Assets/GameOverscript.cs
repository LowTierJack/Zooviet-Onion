using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverscript : MonoBehaviour {

    public void RestartButton() {
        SceneManager.LoadScene(sceneName: "Jack scen");

    }
    public void ExitButton() {
        SceneManager.LoadScene(sceneName: "Main menu");

    }
}
