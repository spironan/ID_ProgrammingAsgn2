using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;



public class UnavailableButtons : MonoBehaviour 
{
    public Canvas MainCanvas;
    public Canvas UnavailableCanvas;
	
    void Awake()
    {
        UnavailableCanvas.enabled = false;
    }

    public void UnavailableOn()
    {
        UnavailableCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        UnavailableCanvas.enabled = false;
        MainCanvas.enabled = true;
    }
}
