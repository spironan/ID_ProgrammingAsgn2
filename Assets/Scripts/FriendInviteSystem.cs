using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FriendInviteSystem : MonoBehaviour {

    public List<Button> FriendButtons = new List<Button>();


    //to update
    private Button currentObject;
    private Button nextObject;

    bool isPressed = false;

	// Use this for initialization
	void Start () {
        currentObject = nextObject = null;
        foreach (Button temp in FriendButtons)
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

    private void InitNext()
    {
        if (nextObject != null)
        {
            nextObject.interactable = true;
        }
    }

    private void ExitCurrent()
    {
        foreach(Button temp in FriendButtons)
        {
           if(temp != currentObject)
           {
               temp.interactable = false;
               isPressed = true; 
           }
           
        }
    }

    public void ChangeButton(string buttonName)
    {
        foreach (Button temp in FriendButtons)
        {
            if (temp.name == buttonName)
                nextObject = temp;
        }
        //if (isPressed)
        //{
            foreach(Button temp in FriendButtons)
            {
                if (isPressed && temp == nextObject)
                {
                    temp.interactable = true;
                    isPressed = false;
                }
                temp.interactable = true;
            }
    }

}
