using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySM : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    public float speed = 1f;
    EnemyFlip flip;
    public float attackRange = 3f;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      player =  GameObject.FindGameObjectWithTag("Player").transform;
      rb =  animator.GetComponent<Rigidbody2D>();
        
        flip = animator.GetComponent<EnemyFlip>();

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {   
        flip.LookAtPlayer(); //method to flip the player

        Vector2 target = new Vector2(player.position.x, rb.position.y); // target the player and code to find the player
        Vector2 newpos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime); //Move towards players position
        rb.MovePosition(newpos);

        flip = animator.GetComponent<EnemyFlip>();
     

        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack"); // script to attack when close to the player distance 


        }
    }

     //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack"); // Resets Attack trigger when finished
    }


}
