using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float speed=2;
    public bool chase =false;
    public Transform startingPoint;
    public int scoreGive=100;
    

    // Update is called once per frame
    void Update()
    {
        if (Player.obj==null)
            return;

        if(chase==true)
            Chase();
        else
            ReturnStartPoint();
    }

    private void Chase()
    {
        transform.position=Vector2.MoveTowards(transform.position, Player.obj.transform.position, speed * Time.deltaTime);
    }

    private void ReturnStartPoint()
    {
        transform.position=Vector2.MoveTowards(transform.position, startingPoint.position,speed * Time.deltaTime);
    }

    // Collision with main collider
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Damage to the player
        if(collision.gameObject.CompareTag("Player"))
        {
            Player.obj.getDamaged();
        }

    }

    //Collision with trigger - Box collider to check if the player jumped over
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy the enemy if If the player collides from above
        if(collision.gameObject.CompareTag("Player"))
        {
            Player.obj.bounceAfterKilledEnemy();
            getKilled();
        }

    }

    void getKilled()
    {
        gameObject.SetActive(false);
    }

}
