using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_board : MonoBehaviour
{
    public Animator animator;
    void Update()
    {       
        if(enemy.score == 1){
            animator.SetFloat("scorepts1",1);
        }
        if(enemy.score == 2){
            animator.SetFloat("scorepts1",2);
        }
        if(enemy.score == 3){
            animator.SetFloat("scorepts1",3);
        }
    }
}
