using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager obj;

    public AudioClip jump;
    public AudioClip soilsample;
    public AudioClip life;
    public AudioClip gui;
    public AudioClip hit;
    public AudioClip enemyHit;
    public AudioClip win;
    public AudioClip gameOver;

    private AudioSource audioSrc;

    void Awake()
    {
        obj = this;
        audioSrc = gameObject.AddComponent<AudioSource>();
    }

    public void playSound(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);       
    }

    public void playJump() { playSound(jump); }
    public void playSoilSample() { playSound(soilsample); }
    public void playLife() { playSound(life); }
    public void playGui() { playSound(gui); }
    public void playHit() { playSound(hit); }
    public void playEnemyHit() { playSound(enemyHit); }
    public void playWin() { playSound(win); }
    public void playGameOver() { playSound(gameOver); }

    void OnDestroy()
    {
        obj = null;
    }
}
