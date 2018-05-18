using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformerMovement : MonoBehaviour {

public float gravity;
float verticalSpeed;

bool isGrounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame ////  {}  ////
	void Update () {
		if (!isGrounded) {
			verticalSpeed -= gravity * Time.deltaTime;
		} else {

		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			verticalSpeed = JumpForce;
			}
			
		transform.Translate(0, verticalSpeed * Time.deltaTime, 0);
		
 } 

	void OnTriggerEnter2D (Collider2D other) {
		if(other.CompareTag("Plataform")) {
			isGrounded = true;
			verticalSpeed = 0;
		}
	}
}
