using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FriendHelpScript : MonoBehaviour {

    public GameObject cdImage;
    private Button button; 

    void Start()
    {
        button = GetComponent<Button>();
        cdImage.SetActive(false);
    }


    public void SummonFriend()
    {
        cdImage.SetActive(true);
        button.interactable = false;
    }
}
