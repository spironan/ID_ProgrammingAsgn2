using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FriendHelpScript : MonoBehaviour {

    public GameObject cdImage;
    private Button button;
    private Image permanantCD;


    void Start()
    {
        button = GetComponent<Button>();
        cdImage.SetActive(false);
        permanantCD = cdImage.GetComponent<Image>();
    }


    public void SummonFriend()
    {
        cdImage.SetActive(true);
        button.interactable = false;
    }
}
