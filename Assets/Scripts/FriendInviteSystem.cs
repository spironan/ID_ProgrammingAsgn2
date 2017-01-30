using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FriendInviteSystem : MonoBehaviour {

    public List<Button> FriendButtons = new List<Button>();


    //to update
    private Button currentObject;
    private Button nextObject;

    bool isPressed;

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
        //if(nextObject.interactable == false)
        //{
        //    foreach(Button temp in FriendButtons)
        //    {
        //        if(temp != nextObject)
        //        {
        //            temp.interactable = true;
        //        }
        //    }
        //}
	}

    private void InitNext()
    {
        if (nextObject != null)
        {
            nextObject.interactable = true;
        }
        //else if(currentObject == nextObject)
        //{
        //    foreach(Button temp in FriendButtons)
        //    {
        //        if(temp != currentObject)
        //        {
        //            temp.interactable = true;
        //        }
        //    }
        //}
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
    }

    //private void CheckPressedButton()
    //{
    //    foreach (Button temp in FriendButtons)
    //    {
    //        if (isPressed)
    //        {
    //            if (temp != currentObject)
    //            {
    //                temp.interactable = true;
    //                isPressed = false;
    //            }
    //        }
    //    }
    //}
}
