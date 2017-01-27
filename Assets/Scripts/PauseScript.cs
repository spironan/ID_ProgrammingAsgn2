using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {

    private bool paused;
    public GameObject pauseText;

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
