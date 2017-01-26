using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}

    public void GoToInventory()
    {
        SceneManager.LoadScene("Inventory");
    }

    public void GoToShop()
    {
        SceneManager.LoadScene("Exchange");
    }

    public void GoToInbox()
    {
        SceneManager.LoadScene("Inbox");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("MainSettings");
    }

    public void GoToExplore()
    {
        SceneManager.LoadScene("Explore");
    }

    public void GoToBeforeBattle()
    {
        SceneManager.LoadScene("BeforeBattle");
    }

    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
