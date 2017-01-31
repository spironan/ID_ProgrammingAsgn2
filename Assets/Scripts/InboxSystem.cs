using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class InboxSystem : MonoBehaviour {

    
	
    //// Update is called once per frame
    //void Update () {
	
    //}
    public Canvas MainCanvas;
    public Canvas FPCanvas;
    public Canvas ItemCanvas;
    public Canvas GiftCanvas;
    public Button FP_btn;
    public Button Item_btn;
    public Button Gift_btn;
    public GameObject confirmationPopupFP;
    public GameObject confirmationPopupItem;
    public GameObject confirmationPopupGift;

    public List<GameObject> itemList = new List<GameObject>();
    public List<GameObject> giftList = new List<GameObject>();
    public List<GameObject> fpList = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        FP_btn.Select();
        FPCanvas.enabled = true;
        ItemCanvas.enabled = false;
        GiftCanvas.enabled = false;
        confirmationPopupFP.SetActive(false);
        confirmationPopupItem.SetActive(false);
        confirmationPopupGift.SetActive(false);
    }

    void Update()
    {
        if(FPCanvas.enabled == true)
        {
            FP_btn.Select();
        }
        else if (ItemCanvas.enabled == true)
        {
            Item_btn.Select();
        }
        else if (GiftCanvas.enabled == true)
        {
            Gift_btn.Select();
        }
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

    public void ClosePopup(string popup)
    {
        if (popup == confirmationPopupFP.name)
            confirmationPopupFP.SetActive(false);

        else if (popup == confirmationPopupItem.name)
            confirmationPopupItem.SetActive(false);

        else if (popup == confirmationPopupGift.name)
            confirmationPopupGift.SetActive(false);
    }

    public void CollectAllFP(string popup)
    {
        if (popup == confirmationPopupFP.name)
            confirmationPopupFP.SetActive(true);

        foreach (GameObject temp in fpList)
        {
            temp.SetActive(false);
        }
    }

    public void CollectAllGifts(string popup)
    {
        if (popup == confirmationPopupGift.name)
            confirmationPopupGift.SetActive(true);

        foreach (GameObject temp in giftList)
        {
            temp.SetActive(false);
        }
    }

    public void CollectAllItems(string popup)
    {
        if (popup == confirmationPopupItem.name)
            confirmationPopupItem.SetActive(true);

        foreach (GameObject temp in itemList)
        {
            temp.SetActive(false);
        }
    }
    
}
