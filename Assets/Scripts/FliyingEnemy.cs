using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliyingEnemy : MonoBehaviour
{
    private Rigidbody2D rb;

    public float movHor=0f;
    public float speed=3f;
    public float initialx=0f;

    public bool isDistanceOver=true;

    public LayerMask groundLayer;
    public float frontCheck=0.51f;
    public float frontDist=0.001f;

    public int scoreGive=50;

    public RaycastHit2D hit;


        // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        initialx=this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float maxDist=5f;
        //To check if if it has already traveled a certain distance x
        isDistanceOver = (transform.position.x - initialx >= maxDist) || (transform.position.x <= initialx);

        //Enemy changes direction if there is not floor in the nex movement
        if(isDistanceOver)
            movHor=movHor * -1;

        
        //Collides with wall
        if (Physics2D.Raycast(transform.position, new Vector3(movHor, 0, 0), frontCheck, groundLayer))
        {
            Debug.Log("Wall");
            initialx=transform.position.x;
            movHor = movHor * -1;
        }
        

        //Collides with other enemy
        
        hit = Physics2D.Raycast(new Vector3(transform.position.x + movHor*frontCheck, transform.position.y, transform.position.z),
            new Vector3(movHor, 0,0), frontDist);

        if (hit)
            if (hit.transform != null)
                if (hit.transform.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy");
                    initialx=transform.position.x;
                    movHor = movHor * -1;
                }
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);
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
    
    // Collision with trigger - Box collider to check if the player jumped over
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
