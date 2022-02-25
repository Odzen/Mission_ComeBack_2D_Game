using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
using UnityEngine.Video;

public class Cinematic : MonoBehaviour
{
    public double time;
    public double currentTime;
    // Use this for initialization
    void Start () {
    time = gameObject.GetComponent<VideoPlayer> ().clip.length;
    }
 
   
    // Update is called once per frame
    void Update () {
        currentTime = gameObject.GetComponent<VideoPlayer> ().time;
        Debug.Log ("//CURRENT TIME");
        Debug.Log (currentTime);
        if (currentTime >= 60.92) {
            SceneManager.LoadScene("Level1");
        }
    }
}
