using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : EnemyObject {

	public int health;
	bool invulnerable = false;
	public platformMovement3D target;
	public Vector3 planarTargetDistance { get { return new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z)}}
	public float colorIndex = 0f;


	void Update () {
		if (target != null) {
			transform.forward = (planarTargetDistance - transform.position).normalized;
		}
		GetComponent<Renderer>().material.color = damageGradient.Evaluate;
	}

	public override void TakeDamage () {
		if (!invulnerable) { 
		health--;
		GetComponent<Animator>().SetTrigger("TakeDamage");
		invulnerable = true;
		}
	}
	
	public void ResetInvulnerable () {
		invulnerable = false;
	}
}
