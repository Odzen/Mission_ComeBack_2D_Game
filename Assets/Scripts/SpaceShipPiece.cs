using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class SpaceShipPiece : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FXManager.obj.showPop(transform.position);
            AudioManager.obj.playWin();
            gameObject.SetActive(false);
            Thread.Sleep(1000);
            SceneManager.LoadScene("Level_selector");
        }
    }
}