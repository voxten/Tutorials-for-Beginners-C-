using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove(2D) : MonoBehaviour
{
    	public float moveSpeed;
	private Animator anim;
	
    	void Start()
   	{
        	anim = GetComponent<Animator> ();
    	}

    	void Update()
    	{
		if(Input.GetKey(KeyCode.D))
		{
		       GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		
		if(Input.GetKey(KeyCode.A))
		{
		       GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		
		anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D> ().velocity.x));
    	}
}
