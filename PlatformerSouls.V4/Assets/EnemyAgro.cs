using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;
    [SerializeField]
    float moveSpeed;


    Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        print("distToPlayer:" + distToPlayer);

        if(distToPlayer < agroRange)
        {
            //chase
            ChasePlayer();
        }
        else
        {
            //stop chase player
            StopChasingPlayer();
        }
    }
    private void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
        }
    }

    private void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }

}
