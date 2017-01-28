using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class InboxSystem : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}
    public Canvas MainCanvas;
    public Canvas FPCanvas;
    public Canvas ItemCanvas;
    public Canvas GiftCanvas;

    void Awake()
    {
        FPCanvas.enabled = true;
        ItemCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    public void FPOn()
    {
        FPCanvas.enabled = true;
        ItemCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    public void ItemOn()
    {
        ItemCanvas.enabled = true;
        FPCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    public void GiftOn()
    {
        GiftCanvas.enabled = true;
        FPCanvas.enabled = false;
        ItemCanvas.enabled = false;
    }

    
}
