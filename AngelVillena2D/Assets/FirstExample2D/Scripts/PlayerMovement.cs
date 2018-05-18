using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public float speed = 4f;

	Animator anim;
	Rigidbody2D rb2d;
	Vector2 mov;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb2d = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.LeftArrow)) { 

			this.transform.position += new Vector3 (-1f, 0, 0) * speed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.RightArrow)) { 

			this.transform.position += new Vector3 (1f, 0, 0) * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.UpArrow)) { 

			this.transform.position += new Vector3 (0, 1f, 0) * speed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.DownArrow)) { 

			this.transform.position += new Vector3 (0, -1f, 0) * speed * Time.deltaTime;
		}
		anim.SetFloat ("MovX", mov.x);
		anim.SetFloat ("MovY", mov.y);
	}
	//	{} 
}
