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
    void Start () {
    time = Math.Truncate(gameObject.GetComponent<VideoPlayer> ().clip.length);
    }
    void Update () {
        currentTime = Math.Truncate(gameObject.GetComponent<VideoPlayer> ().time);
        if (currentTime >= time) {
            SceneManager.LoadScene("MiainMenu");
        }
    }
}
