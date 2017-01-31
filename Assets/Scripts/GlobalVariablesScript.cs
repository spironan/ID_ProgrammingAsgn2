using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GlobalVariablesScript : MonoBehaviour {

    public static SceneNodes currentScene;
    public static List<SceneNodes> sceneTracking = new List<SceneNodes>();

    void Start()
    {
        SceneNodes temp = GetComponent<SceneNodes>();
        Debug.Log(temp.name);
        if (sceneTracking.Count > 0)
        { 
            temp.SetPrev(sceneTracking[sceneTracking.Count - 1]);
            sceneTracking[sceneTracking.Count - 1].SetNext(temp);
        }
        sceneTracking.Add(temp);
        currentScene = sceneTracking[sceneTracking.Count - 1];
        //Debug.Log("Current Scene : " + currentScene.name.ToString() );
    }

    public void GenericBackButton()
    {
        if (currentScene.GetPrev() != null)
        { 
            currentScene = currentScene.GetPrev();
            SceneManager.LoadScene(currentScene.GetSceneName());
        }
        Debug.Log("Current Scene" + currentScene.name.ToString());
    }

}
