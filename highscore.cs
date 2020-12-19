using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
   
   public Text myText;

   public void Update(){
      myText.text = ball.level.ToString();
   }
}