using System.Collections;
using UnityEngine;

public class soundscript : MonoBehaviour
{

    void Awake(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
        GameObject[] objs1 = GameObject.FindGameObjectsWithTag("winsound");
        if(objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

}