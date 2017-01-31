using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public GameObject pauseScreen;
    private bool paused;

    void Start()
    {
        paused = false;
        pauseScreen.SetActive(false);
    }

    public void Pause()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            paused = true;
        }
        else
        { 
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
            paused = false;
        }
    }
}
