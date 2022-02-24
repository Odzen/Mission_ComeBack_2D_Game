using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soilsample : MonoBehaviour
{
    public int scoreGive = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Game.obj.addScore(scoreGive);
            FXManager.obj.showPop(transform.position);
            gameObject.SetActive(false);
        }
    }
}
