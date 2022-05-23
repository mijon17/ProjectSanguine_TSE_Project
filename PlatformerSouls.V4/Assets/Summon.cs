using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{

	float moveSpeed = 7f;
	

	Rigidbody2D rb;

	PlayerController target;
	Vector2 moveDirection;

	[SerializeField]
	private int attackDamage = 10;

	private PlayerHealth healthManage;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindObjectOfType<PlayerController>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		Destroy(gameObject, 3f);

		healthManage = FindObjectOfType<PlayerHealth>();

		//explosionSource = GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("Player"))
		{
			Debug.Log("Hit!");
			//Destroy (gameObject);


			col.GetComponent<PlayerHealth>().TakeDamage(attackDamage);

		}

	}


}
