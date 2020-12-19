using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public static int score = 0;
    public float health = 7f;
    public static bool checksound = false;
    public GameObject FloatingTextPrefab;
    public float tempCol;
    public int tempColi;
    public string miss = "miss";
    public string eat = "NamNam";
    public static bool scorecheck = true;
    void OnCollisionEnter2D(Collision2D colInfo){
        Debug.Log(colInfo.relativeVelocity.magnitude);
        tempCol = colInfo.relativeVelocity.magnitude;
        tempColi = (int)tempCol;
        if(colInfo.relativeVelocity.magnitude > health && (scorecheck == true)){
            ball.amadelo = true;
            ScoreUp();
            checksound = true;
        }
        if(FloatingTextPrefab){
            if(colInfo.relativeVelocity.magnitude > 2){
                ShowFloatingtext();
            }
        if(score < 2){
            
        }
    }}
    void ScoreUp(){
        
        score++;
        scorecheck = false;
        
    }
    void ShowFloatingtext(){
        Vector3 vec = new Vector3(0.0f,1.0f,0.0f);
        var text = Instantiate(FloatingTextPrefab, transform.position+vec ,Quaternion.identity);
        
        if(tempCol > health){
            text.GetComponent<TextMesh>().text = eat;
        }
        else{
            text.GetComponent<TextMesh>().text = miss;
    }
    }
}
