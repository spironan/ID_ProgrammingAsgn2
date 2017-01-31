using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopSystemScript : MonoBehaviour {

    public GameObject purchaseScreen;
    public GameObject itemInfoScreen;
    private Image purchaseImage;
    private Image itemInfoImage;

    void Start()
    {
        purchaseScreen.SetActive(false);
        itemInfoScreen.SetActive(false);
        purchaseImage = purchaseScreen.GetComponent<Image>();
        itemInfoImage = itemInfoScreen.GetComponent<Image>();
    }

    public void Open(string name)
    {
        if (name == purchaseScreen.name)
            purchaseScreen.SetActive(true);
        else if (name == itemInfoScreen.name)
            itemInfoScreen.SetActive(true);
    }

    public void Close(string name)
    {
        if (name == purchaseScreen.name)
            purchaseScreen.SetActive(false);
        else if (name == itemInfoScreen.name)
            itemInfoScreen.SetActive(false);
    }
}
