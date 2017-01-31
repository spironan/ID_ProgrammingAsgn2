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
        GameObject.FindGameObjectWithTag("GlobalVariable").GetComponent<GlobalVariablesScript>().AddScene(this);
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
        return sceneName;
    }

    public void SetPrev(SceneNodes prevScene)
    {
        this.prev = prevScene;
    }

    public void SetNext(SceneNodes nextScene)
    {
        this.next = nextScene;
    }

    public void SetSceneName(string sceneName)
    {
        this.sceneName = sceneName;
    }

    public void GenericBackButton()
    {
        GameObject.FindGameObjectWithTag("GlobalVariable").GetComponent<GlobalVariablesScript>().BackButton();
    }
}
