using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GlobalVariablesScript : MonoBehaviour {

    private static List<SceneNodes> data = new List<SceneNodes>();

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void AddScene(SceneNodes newData)
    {
        if (data.Count > 1)
        { 
            data[data.Count - 1].SetNext(newData);
            newData.SetPrev(data[data.Count - 1]);
        }
        data.Add(newData);
    }

    public void BackButton()
    {
        Debug.Log(data[data.Count - 1].GetSceneName());
        if (data.Count > 1)
        {
            SceneManager.LoadScene(data[data.Count - 2].GetSceneName());
            data.Remove(data[data.Count - 1]);
        }
    }
}
