﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBallBehaviour : MonoBehaviour {


	public PlatformMovement3D activePlayer;
	public Collider triggerArea;
	public readonly string containerName = "PowerContainer";
	public readonly Vector3 idlePoint = new Vector3(0.5f, 0.75f, 0f);



	bool waitForNextAction = false;
	public bool isWaiting {get {return waitForNextAction}}

	// Use this for initialization
	void Start () {
		if (!activePlayer) {
			triggerArea.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AssignActivePlayer (PlatformMovement3D targetPlayer) {
		activePlayer = targetPlayer;
		transform.SetParent (activePlayer.transform/*.Find()*/);
		transform.localPosition =idlePoint;
		transform.rotation = targetPlayer.transform.rotation;
		triggerArea.enabled = false;
		GetComponent<Animator>().SetFloat ("idleSpeed", 0.5f);
	}

	public void AttackRoundAbout () {
		GetComponent<Animator> ().
		transform.parent.localPosition = center;
		GetComponent<Animator> ().SetTrigger ("RoundAbout");
	}
	public void ResetPoint () {
		ransform.parent.localPosition
	}
}
