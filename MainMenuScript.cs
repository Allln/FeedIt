using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public static GameObject highscore;
    public static void StartGame(){
        ball.window = false;
        SceneManager.LoadScene(ball.level);   
        }

    public void GoToTrophyRoom(){
        SceneManager.LoadScene("score");
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("1");
    }

    public void ResetPlayerPrefs(){
        ball.check = 2;
        ball.level = 2;
        PlayerPrefs.DeleteAll();
    }
    public void ResetLevel(){
        ball.window = false;
        enemy.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ball.anim = false;

        
    }

}
