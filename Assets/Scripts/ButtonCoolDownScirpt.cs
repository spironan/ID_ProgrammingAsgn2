using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonCoolDownScirpt : MonoBehaviour {

    public GameObject cdImage;
    public float coolDownDuration;

    private Button button;
    private Image cooldown;
    private bool buttonDown = false;

	// Use this for initialization
	void Start () 
    {
        cdImage.SetActive(false);
        cooldown = cdImage.GetComponent<Image>();
        button = GetComponent<Button>();
        button.interactable = true;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Time.timeScale == 1)
        {
            if (buttonDown)
            {
                if (cooldown.fillAmount > 0)
                    cooldown.fillAmount -= (float)((1.0f / coolDownDuration) * Time.deltaTime );
                //(float)(1.0f/coolDownDuration/60.f)
                else
                {
                    buttonDown = false;
                    button.interactable = true;
                    cdImage.SetActive(false);
                    cooldown.fillAmount = 1.0f;
                }
            }
        }
	}

    public void ButtonPressed()
    {
        if (Time.timeScale == 1)
        {
            if (!buttonDown)
            {
                cdImage.SetActive(true);
                button.interactable = false;
                buttonDown = true;
            }
        }
    }
}
