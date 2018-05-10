using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public float speed = 4f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mov = new Vector3 (
			              Input.GetAxisRaw ("Horizontal"),
			              Input.GetAxisRaw ("Vertical"),
			              0
		              );
		transform.position = Vector3.MoveTowards(
		transform.position;
		transform.position + mov;
		speed * Time.deltaTime;
		)
	}
	/*
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
	*/
}
