using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public GameObject pauseText;
    private bool paused;

    void Start()
    {
        paused = false;
        pauseText.SetActive(false);
    }

    public void Pause()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
            SceneManager.LoadScene("InGameSettings");
            paused = true;
        }
        else
        { 
            Time.timeScale = 1;
            pauseText.SetActive(false);
            paused = false;
        }
    }
}
