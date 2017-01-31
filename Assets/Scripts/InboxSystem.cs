using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

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

    public List<GameObject> itemList = new List<GameObject>();
    public List<GameObject> giftList = new List<GameObject>();
    public List<GameObject> fpList = new List<GameObject>();

    void Awake()
    {
        FPCanvas.enabled = true;
        ItemCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    private void FPOn()
    {
        FPCanvas.enabled = true;
        ItemCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    private void ItemOn()
    {
        ItemCanvas.enabled = true;
        FPCanvas.enabled = false;
        GiftCanvas.enabled = false;
    }

    private void GiftOn()
    {
        GiftCanvas.enabled = true;
        FPCanvas.enabled = false;
        ItemCanvas.enabled = false;
    }

    public void CollectFP(string rowName)
    {
        foreach (GameObject temp in fpList)
        {
            if (temp.name == rowName)
                temp.SetActive(false);
        }
    }

    public void CollectGift(string rowName)
    {
        foreach (GameObject temp in giftList)
        {
            if (temp.name == rowName)
                temp.SetActive(false);
        }
    }

    public void CollectItem(string rowName)
    {
        foreach (GameObject temp in itemList)
        {
            if (temp.name == rowName)
                temp.SetActive(false);
        }
    }

    public void CollectAllFP()
    {
        foreach (GameObject temp in fpList)
        {
            temp.SetActive(false);
        }
    }

    public void CollectAllGifts()
    {
        foreach (GameObject temp in giftList)
        {
            temp.SetActive(false);
        }
    }

    public void CollectAllItems()
    {
        foreach (GameObject temp in itemList)
        {
            temp.SetActive(false);
        }
    }
}
