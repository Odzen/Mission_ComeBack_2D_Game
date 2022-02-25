using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Video;

public class Credits : MonoBehaviour
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

