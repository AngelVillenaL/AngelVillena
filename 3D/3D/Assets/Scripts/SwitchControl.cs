using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour {

	public Transform platform;
	public Vector3 targetPoint;
	public float transitionSpeed;

	bool _enabled;
	public bool isEnabled {get{ return _enabled; }}
	public Color enabledColor;
	public Color disabledColor;
	Renderer objectRenderer;

	public SwitchControl alternateSwitch;

	delegate void SwitchSetDelegate (bool setValue);


	// Use this for initialization
	void Awake () {
		objectRenderer = GetComponent<Renderer> ();
		SetEnabled(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetEnabled (bool enabledState) {
		if (alternateSwitch != null) 
		{alternateSwitch.SetEnabled (enabledState);}
		objectRenderer.material.color = enabledState ? enabledColor : disabledColor;
		_enabled = enabledState;
	}

	public void SayDebug (bool canSay) {
		Debug.Log (canSay);
	}

	public void Activate () {
		if (isEnabled) {
		Debug.Log ("Activated" + name);

		StartCoroutine (MovePlatformToTargetPoint ());
		SetEnabled (false);
		}
	}
	IEnumerator MovePlatformToTargetPoint () {
		Vector3 nextTarget = platform.position;
		Rigidbody platformRigidbody = platform.GetComponent<RigidBody> ();
		while (platform.position != targetPoint) {
			platformRigidboddy.MovePosition(Vector3.MoveTowards (platform.position, targetPoint, transitionSpeed * Time.deltaTime))
		    //platform.position = Vector3.MoveTowards (platform.position, targetPoint, transitionSpeed * Time.deltaTime);
		    yield return null;
	    }
	    targetPoint = nextTarget;
	    if (alternateSwitch != null) {alternateSwitch.targetPoint = nextTarget; }
	    SetEnabled(true);
		yield return null;
	}
}
