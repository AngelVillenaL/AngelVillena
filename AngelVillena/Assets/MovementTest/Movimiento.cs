using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	public float speed;
	public Vector3 direction;
	public Vector3 limit;
	public Rigidbody playerRB;
	public Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
        playerRB = GetComponent<Rigidbody>();

    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKey (KeyCode.A) && transform.position.x > -limit.x) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D) && transform.position.x < limit.x) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.W) && transform.position.z < limit.z) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.S) && transform.position.z > -limit.z) {
			transform.Translate (Vector3.back * speed * Time.deltaTime);
		}

	}

	void OnCollisionEnter (Collision col) 
	{
		if (col.gameObject.CompareTag("Wall"))
		{
            transform.position = posicionInicial;
            Debug.Log("Intentalo de nuevo...");
        }
		else if (col.gameObject.CompareTag("Exit"))
		{
			Debug.Log ("Felicidades! Ganaste!");
		}

	}

	//Debug.Log ("Intentalo de nuevo...");
	//miRigidBody.MovePosition (posicionInicial);


	}
