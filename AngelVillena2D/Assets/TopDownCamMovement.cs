using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamMovement : MonoBehaviour {

    public Transform targetObject;
    TopDownShooterMovement targetScript;
    public Color targetColor;
    public float distance = 1;
    public float maxDistanceDelta = 1;

	// Use this for initialization
	void Start () {
        targetScript =targetObject.GetComponent<TopDownShooterMovement> ();

    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetCamPos = targetObject.position + (Vector3.up * distance);
        Vector3  currentCamPos = transform.position;
        targetCamPos.z = transform.position.z;
        float currentDistance = Vector3.Distance(currentCamPos, targetCamPos);
        transform.position = Vector3.MoveTowards(transform.position, targetCamPos, maxDistanceDelta * currentDistance * Time.deltaTime);

	}

    void OnDrawGizmos () {
        //Draw a yellow sphere at the transform's position
        Gizmos.color = targetColor;
        Vector3 targetViewPos = (targetScript != null) ? targetObject.position + (targetScript.sightDirection.up * distance) :Vector3.zero ;
        Gizmos.DrawWireSphere(targetViewPos, 0.5f);
        Gizmos.color = Color.red;
        Vector3 currentViewPos = new Vector3 (transform.position.x, transform.position.y, 0);
        Gizmos.DrawWireSphere(currentViewPos, 0.5f);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(currentViewPos, targetViewPos);
    }
}

