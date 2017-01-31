using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NinjaAnimationScript : MonoBehaviour
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
    }

    void Update()
    {

        if (!canAttack && attack.interactable)
        { 
            canAttack = true;
            anim_ninja.SetInteger("State", 0);
        }
        if (!canUseSkill1 && Skill1.interactable)
        {
            canUseSkill1 = true;
            anim_ninja.SetInteger("State", 0);
        }
        if (!canUseSkill2 && Skill2.interactable)
        { 
            canUseSkill2 = true;
            anim_ninja.SetInteger("State", 0);
        }
    }

    public void Attack()
    {
        if (canAttack)
        { 
          anim_ninja.SetInteger("State", 2);
          canAttack = false;
        }
    }

    public void UseSkill1()
    {
        if (canUseSkill1)
        {
            anim_ninja.SetInteger("State", 3);
            canUseSkill1 = false;
        }
    }


    public void UseSkill2()
    {
        if (canUseSkill2)
        {
            anim_ninja.SetInteger("State", 4);
            canUseSkill2 = false;
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
