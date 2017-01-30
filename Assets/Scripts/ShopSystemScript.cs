using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopSystemScript : MonoBehaviour {

    public GameObject purchaseScreen;
    private Image purchaseImage;

    void Start()
    {
        purchaseScreen.SetActive(false);
        purchaseImage = purchaseScreen.GetComponent<Image>();
    }

    public void Open()
    {
        purchaseScreen.SetActive(true);
    }

    public void Close()
    {
        purchaseScreen.SetActive(false);
    }
}
