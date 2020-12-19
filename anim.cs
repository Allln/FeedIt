using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if(ball.anim == true){
            animator.SetFloat("throw",1);}
        else{
            animator.SetFloat("throw",0);
        }
        }
    }
