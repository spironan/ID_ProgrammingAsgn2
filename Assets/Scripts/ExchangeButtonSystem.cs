using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ExchangeButtonSystem : MonoBehaviour {

    public List<GameObject> scrollViewList = new List<GameObject>();
    
    //For fading uses
    private Color alphaColor;
    public float timeToFade = 1.0f;

    //to update
    private GameObject currentObject;
    private GameObject nextObject;

    void Start()
    {
        currentObject = nextObject = null;
       
        foreach (GameObject temp in scrollViewList)
        {
            if(temp.name == "Tab_Featured")
                nextObject = temp;
            else
                temp.SetActive(false);
        }
        
    }

    void Update()
    {
        if (nextObject != currentObject)
        {
            ExitCurrent();
            InitNext();
            currentObject = nextObject;
        }
    }

    private void ExitCurrent()
    {
        if (currentObject != null)
        {
            float too = FadeOut(currentObject);
            while ( too > 0.0f)
            {
                too = FadeOut(currentObject);
            }
            currentObject.SetActive(false);
        }
    }

    private void InitNext()
    {
        if (nextObject != null)
        {
            //while(FadeIn(nextObject) < 1.0f)
            //{
            //}
            nextObject.SetActive(true);
        }

    }

    //private float FadeIn(GameObject fadingObject)
    //{
    //    fadingObject.GetComponent<MeshRenderer>().material.color 
    //        = Color.Lerp(fadingObject.GetComponent<MeshRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);

    //    return fadingObject.GetComponent<MeshRenderer>().material.color.a;
    //}

    private float FadeOut(GameObject fadingObject)
    {
        fadingObject.GetComponent<MeshRenderer>().material.color
            = Color.Lerp(fadingObject.GetComponent<MeshRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);

        return fadingObject.GetComponent<MeshRenderer>().material.color.a;
    }


    public void ChangeTab(string tabName)
    {
        foreach (GameObject temp in scrollViewList)
        {
            if (temp.name == tabName)
                nextObject = temp;
        }
    }


}
