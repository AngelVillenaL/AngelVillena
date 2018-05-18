using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour {

private SpriteRenderer spriteRenderer;
public Sprite spriteUp;
public Sprite spriteDown;
public Sprite spriteRight;
public Sprite spriteLeft;

public Animator animator;
public RuntimeAnimatorController WalkUp;
public RuntimeAnimatorController WalkDown;
public RuntimeAnimatorController WalkRight;
public RuntimeAnimatorController WalkLeft;

int directionIndex = 0;


	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = spriteUp;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			spriteRenderer.sprite = spriteLeft;
			animator = GetComponent<Animator>();
			}

		if (Input.GetKeyDown(KeyCode.D)) {
			spriteRenderer.sprite = spriteRight;
			}

		if (Input.GetKeyDown(KeyCode.W)) {
			spriteRenderer.sprite = spriteUp;
			}

		if (Input.GetKeyDown(KeyCode.S)) {
			spriteRenderer.sprite = spriteDown;
			}
	

			animator.SetInteger("direction", directionIndex);

		if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) {
				animator.SetInteger("direction", -1);
			} 

	} 
}
