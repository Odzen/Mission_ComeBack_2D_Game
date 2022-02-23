using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyTest : MonoBehaviour
{
    public float speed=2;
    private GameObject player;
 
    private void Start()
    {
        player= GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.obj==null)
            return;
        Chase();
    }

    private Chase()
    {
        transform.position=Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
