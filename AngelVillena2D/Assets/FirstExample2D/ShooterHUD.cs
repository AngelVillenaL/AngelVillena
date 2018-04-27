using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShooterHUD : MonoBehaviour {


    public TopDownShooterMovement player;
    Text debugText;
    public float spacing;
    Transform collection;
    public GameObject weaponPrefab;
    int lastColorIndex;

    // Use this for initialization
    void Start () {
        debugText = transform.Find ("DebugText").GetComponent<Text>();
        collection = transform.Find("WeaponCollection");
        for (int i = 0; i < player.colors.Count; i++) {
            Instantiate(weaponPrefab, collection).GetComponent<Image>().color = player.colors[];
            collection.GetChild(i).position = new Vector3(spacing* i, 0, 0);
        }
        lastColorIndex = player.ColorIndex;
    }
	
	// Update is called once per frame
	void Update () {
        //debugText.text = "Weapon Index" + player.ColorIndex;
        if(lastColorIndex != player.ColorIndex) 
        Transform targetObject = transform.Find ("WeaponCollection").GetChild(0);
        float targetSize = (if == player)
        collection.GetChild(player.ColorIndex).GetComponent<RectTransform>;
		
	}
    void LateUpdate () {
        lastColorIndex = player.ColorIndex;
    }
}
