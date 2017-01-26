using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PurchaseCurrency : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}

    public void PurchaseKey()
    {
        SceneManager.LoadScene("Exchange");
    }

    public void PurchaseCoin()
    {
        SceneManager.LoadScene("Exchange");
    }

    public void PurchaseJewel()
    {
        SceneManager.LoadScene("Exchange");
    }

    public void PurchaseFP()
    {
        SceneManager.LoadScene("Exchange");
    }

}
