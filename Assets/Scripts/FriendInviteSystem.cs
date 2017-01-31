using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FriendInviteSystem : MonoBehaviour {

    public List<Button> FriendButtons = new List<Button>();

    //to update
    private Button currentObject;

    bool isPressed = false;

	// Use this for initialization
	void Start () {
        currentObject = null;
        foreach (Button temp in FriendButtons)
        {
            temp.interactable = true;
        }
	}
	
    public void ChangeButton(string buttonName)
    {
        //Check if any existing buttons is pressed
        if (!isPressed)
        {
            foreach (Button temp in FriendButtons)
            {
                if (temp.name == buttonName)
                {
                    currentObject = temp;
                    currentObject.interactable = true;
                }
                else
                {
                    temp.interactable = false;
                }
            }
            isPressed = true;
            currentObject.GetComponentInChildren<Text>().text = "UnInvite";
        }
        else // if button is pressed
        {
            //check if it is the same button that is pressed
            if (currentObject.name == buttonName)
            {
                foreach (Button temp in FriendButtons)
                {
                    temp.interactable = true;
                }
                isPressed = false;
                currentObject.GetComponentInChildren<Text>().text = "Invite";
            }
        }
    }

}
