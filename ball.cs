using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook; 
    private bool isPressed = false;
    public float maxDragDistance = 2f;
    public float releaseTime = 0.15f;
    public GameObject nextBall;
    public static bool anim = false;
    public static bool amadelo = false;
    public static bool window = false;
    public static int level = 2;
    public GameObject highscore;
    public static int check = 2;
    public AudioSource eats;
    public AudioSource throws;
    public AudioSource wins;
    bool highcheck = false;
    void Start(){
        level = PlayerPrefs.GetInt("highscore");
        if(level > 0){
            highcheck = true;
        }
        else{
            level = 2;
        }
    }
    void Update(){
        if(isPressed){
            anim = false;
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Vector3.Distance(mousePos, hook.position) > maxDragDistance){
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            }
            else
            {
                rb.position = mousePos;
            }
        }
    }
    void OnMouseDown(){
        isPressed = true;
        rb.isKinematic = true;
    }
    void SaveF(){
        check = PlayerPrefs.GetInt("highscore");
        Debug.Log(check);
        if(check > 1){
        }
        else{
            PlayerPrefs.SetInt("highscore", 2);
        }
        level = check;
    }
     void OnMouseUp(){  
        isPressed = false;
        rb.isKinematic = false;
        anim = true;

        StartCoroutine(AnimCheck());
        StartCoroutine(Release());
        throws.Play();
        SaveF();
    }
    IEnumerator AnimCheck(){
        yield return new WaitForSeconds(0.55f);
        anim = false;
    }
    IEnumerator Release(){
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
        yield return new WaitForSeconds(3.5f);
        anim = false;
        if(enemy.checksound == true){
            enemy.checksound = false;
            eats.Play();
        }
        if(enemy.score >= 3){
            wins.Play();
            level = level + 1;
            PlayerPrefs.SetInt("highscore",level);
            
            enemy.score = 0;
            SceneManager.LoadScene(level);
            window = true;
        }
        if(nextBall != null){
            nextBall.SetActive(true);
            amadelo = false;
            enemy.scorecheck = true;
        }
        else{
            enemy.score = 0;
            SceneManager.LoadScene(check);
        }
    }
}
