using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class Killer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AudioManager.obj.playGameOver();
            Thread.Sleep(1000);
            Game.obj.gameOver();
        }
    }
}
