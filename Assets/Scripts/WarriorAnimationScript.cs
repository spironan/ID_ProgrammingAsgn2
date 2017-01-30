using UnityEngine;
using System.Collections;

public class WarriorAnimationScript : MonoBehaviour {

    public GameObject warrior;
    public Vector3 finalLocation;
    private Animator warrior_anim;
    private bool callForHelp;

	// Use this for initialization
	void Start () {
        finalLocation = new Vector3(0, 0, 0);
        warrior_anim = warrior.GetComponent<Animator>();
        callForHelp = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (callForHelp && Vector3.Distance(warrior.transform.position,finalLocation)> 1.0f)
        {
            warrior.transform.position += ((finalLocation - warrior.transform.position).normalized) * Time.deltaTime * 5;
            warrior_anim.SetBool("New Bool", true);
        }
        if (Vector3.Distance(warrior.transform.position, finalLocation) <= 1.0f)
        {
            callForHelp = false;
            warrior_anim.SetBool("New Bool", false);
        }
	}


    public void Help()
    {
        if (!callForHelp && warrior.transform.position != finalLocation)
        {
            callForHelp = true;
        }
    }
}
