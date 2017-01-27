using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WarriorAnimationScript : MonoBehaviour
{
    public Animator anim_ninja;
    public Button attack;
    public Button Skill1;
    public Button Skill2;

    private bool canAttack;
    private bool canUseSkill1;
    private bool canUseSkill2;

    // Use this for initialization
    void Start()
    {
        anim_ninja = GetComponent<Animator>();
        canAttack = true;
        canUseSkill1 = true;
        canUseSkill2 = true;
        Debug.Log("started");
        Debug.Log(anim_ninja.GetInteger("State"));
    }

    void Update()
    {
        if (anim_ninja.GetInteger("State") == 2
            && !canAttack
            && attack.interactable)
        {
            anim_ninja.SetInteger("State", 0);
            canAttack = true;
        }

        else if (anim_ninja.GetInteger("State") == 3
            && !canUseSkill1
            && Skill1.interactable)
        {
            anim_ninja.SetInteger("State", 0);
            canUseSkill1 = true;
        }

        else if (anim_ninja.GetInteger("State") == 4
            && !canUseSkill2
            && Skill2.interactable)
        {
            anim_ninja.SetInteger("State", 0);
            canUseSkill2 = true;
        }
    }

    public void Attack()
    {
        if (canAttack)
        { 
          anim_ninja.SetInteger("State", 2);
          canAttack = false;
          Debug.Log("started");
        }
    }

    public void UseSkill1()
    {
        if (canUseSkill1)
        {
            anim_ninja.SetInteger("State", 3);
            canUseSkill1 = false;
            Debug.Log("started");
        }
    }


    public void UseSkill2()
    {
        if (canUseSkill2)
        {
            anim_ninja.SetInteger("State", 4);
            canUseSkill2 = false;
            Debug.Log("started");
        }
    }


    public void Run()
    {
        anim_ninja.SetInteger("State", 1);
    }

    public void Idle()
    {
        anim_ninja.SetInteger("State", 0);
    }
}
