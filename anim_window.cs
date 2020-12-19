using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_window : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
    //*    animator.SetFloat("active_win", 2.0f);
    if(ball.window == true){
        animator.SetBool("active_w", true);
    }
    if(ball.window == false){
        animator.SetBool("active_w", false);
    }
    }
}
