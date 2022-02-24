using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.obj.addLive();
        
            FXManager.obj.showPop(transform.position);
            gameObject.SetActive(false);
        }
    }
}
