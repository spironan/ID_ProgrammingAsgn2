using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneNodes : MonoBehaviour {

    private SceneNodes next;
    private SceneNodes prev;
    private string sceneName;

	// Use this for initialization
	void Start () {
        next = prev = null;
        sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);
	}

    public SceneNodes GetPrev()
    {
        return prev;
    }

    public SceneNodes GetNext()
    {
        return next;
    }

    public string GetSceneName()
    {
        Debug.Log(sceneName);
        return sceneName;
    }

    public void SetPrev(SceneNodes prevScene)
    {
        this.prev = prevScene;
    }

    public void SetNext(SceneNodes nextScene)
    {
        next = nextScene;
    }

    public void SetSceneName(string sceneName)
    {
        this.sceneName = sceneName;
    }
}
