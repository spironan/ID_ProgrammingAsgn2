using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour {

    public List<GameObject> equipmentList = new List<GameObject>();
    public List<GameObject> equipmentTabList = new List<GameObject>();
    public List<Button> equipButtonList = new List<Button>();

    public Canvas EquipmentCanvas;
    public Canvas ConsumableCanvas;
    public Button currentButton;
    bool isPressed;

    //to update
    private GameObject currentObject;
    private GameObject nextObject;

	// Use this for initialization
	void Start () {
        EquipmentCanvas.enabled = true;
        ConsumableCanvas.enabled = false;

        currentObject = nextObject = null;
        currentButton = null;

        foreach (GameObject temp in equipmentTabList)
        {
            if (temp.name == "Helmet")
                nextObject = temp;
            else
                temp.SetActive(false);
        }

        foreach (Button temp in equipButtonList)
        {
            temp.interactable = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (nextObject != currentObject)
        {
            ExitCurrent();
            InitNext();
            currentObject = nextObject;
        }
	}

    private void ExitCurrent()
    {
        if (currentObject != null)
        {
            currentObject.SetActive(false);
        }
    }

    private void InitNext()
    {
        if (nextObject != null)
        {
            nextObject.SetActive(true);
        }

    }

    public void ChangeTab(string tabName)
    {
        foreach (GameObject temp in equipmentTabList)
        {
            if (temp.name == tabName)
                nextObject = temp;
        }
    }

    public void EquipmentOn()
    {
        EquipmentCanvas.enabled = true;
        ConsumableCanvas.enabled = false;
    }

    public void ConsumableOn()
    {
        EquipmentCanvas.enabled = false;
        ConsumableCanvas.enabled = true;
    }

    public void EquipButton(string buttonName)
    {
        foreach (Button temp in equipButtonList)
        {
            if (temp.name == buttonName)
                currentButton = temp;
        }
    }
}
