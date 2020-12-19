using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_amad : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if(ball.amadelo == true){
            animator.SetFloat("roll", 0);}
        else{
            animator.SetFloat("roll", 2);
        }
        }
    }
