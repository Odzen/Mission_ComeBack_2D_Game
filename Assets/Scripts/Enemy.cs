using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;

    public float movHor=0f;
    public float speed=3f;

    public bool isGroundFloor=true;
    public bool isGroundFront=false;

    public LayerMask groundLayer;
    public float frontGrndRayDist=0.25F;
    public float floorCheckY=0.52f;
    public float frontCheck=0.51f;
    public float frontDist=0.001f;

    public int scoreGive=50;

    public RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Avoid falling if there is not ground
        //To check if we have an object of type ground in some distance
        isGroundFloor = (Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - floorCheckY, transform.position.z),
            new Vector3(movHor, 0, 0), frontGrndRayDist, groundLayer));
        //Enemy changes direction if there is not floor in the nex movement
        if(!isGroundFloor)
            movHor=movHor * -1;

        //Collides with wall
        if (Physics2D.Raycast(transform.position, new Vector3(movHor, 0, 0), frontCheck, groundLayer))
            movHor = movHor * -1;

        //Collides with other enemy
        hit = Physics2D.Raycast(new Vector3(transform.position.x + movHor*frontCheck, transform.position.y, transform.position.z),
            new Vector3(movHor, 0,0), frontDist);

        if (hit)
            if (hit.transform != null)
                if (hit.transform.CompareTag("Enemy"))
                    movHor = movHor * -1;
        
        flip(movHor);
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

    public void flip(float _xValue)
    {
        Vector3 theScale = transform.localScale;

        if (_xValue < 0)
            theScale.x = Mathf.Abs(theScale.x) * -1;
        else
        if (_xValue>0)
            theScale.x = Mathf.Abs(theScale.x);

        transform.localScale = theScale;
    }

    void getKilled()
    {
        FXManager.obj.showPop(transform.position);
        gameObject.SetActive(false);
    }
}
