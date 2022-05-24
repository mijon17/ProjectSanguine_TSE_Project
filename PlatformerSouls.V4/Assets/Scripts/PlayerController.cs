using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 5f;
    bool facingRight = true;

    private Rigidbody2D _rigidbody;

    public Animator animator;
    bool onGround = true;


    public void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        //Movement Code
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        animator.SetFloat("Speed", Mathf.Abs(movement));

        //Jump Code
        if (Input.GetButtonDown("Jump") && onGround)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            onGround = false;
           animator.SetTrigger("Jump");
        }



        if (movement < 0 && facingRight)
        {
            flip();
        }
        else if (movement > 0 && !facingRight)
        {
            flip();
        }

        if(Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            onGround = true;
        }

    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }

}
