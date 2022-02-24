using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipPiece : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.obj.playWin();
            gameObject.SetActive(false);
        }
    }
}