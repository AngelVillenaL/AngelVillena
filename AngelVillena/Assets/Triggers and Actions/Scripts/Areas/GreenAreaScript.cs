using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAreaScript : MonoBehaviour {

    public Light targetLight;
    public bool runUpdate;

    void OnTriggerStay(Collider other) {
        Debug.Log("Stay");
        if (Input.GetKeyDown(KeyCode.Space) && other.CompareTag("Player"))
        {
            targetLight.enabled = !targetLight.enabled;
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            runUpdate = false;
        }
    }
    void Update () {
                if (runUpdate) {
                    if (((int)Time.time) % 2 == 0) {
                        targetLight.enabled = !targetLight.enabled;
                    }
                }
            }
        }
