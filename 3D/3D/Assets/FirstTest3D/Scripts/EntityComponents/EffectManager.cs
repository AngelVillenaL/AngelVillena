using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour {

    static public EffectManager instance;
    List<Effect> effects;


    void Awake () {
        if(instance == null) {
            instance = this;
        }
    }


	// Use this for initialization
	void Start () {
        effects = new List<Effect>();

        effects.Add(new OvertimeEffect("Frost", new Color(93, 192, 255, 200), 2f))
	// Update is called once per frame
	void Update () {
		
	}

    public Effect Search (string id) {
        Effect retEffect = effects.Find(effects => effect.componentName == targetName);
        return (retEffect != null) ? retEffect : new Effect();
    }
}
