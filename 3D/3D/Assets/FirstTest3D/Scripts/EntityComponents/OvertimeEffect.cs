using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvertimeEffect : Effect {
    float currentTime;
    float duration;
    bool done;

    public OvertimeEffect(string name, Color color, float duration = 1f)
    {
        this.name = name;
        this.color = color;
        this.duration = duration;
    }

    public override bool Update( float frameDelta)
	{
        currentTime += frameDelta;
        done = (currentTime >= duration);
        return done;
	}

    public override void OnApply(ref EnemyEntity enemyEntity) {
        Debug.Log(name + " was applied");
        EnemyEntity.speed = 1.5f;
        enemyEntity.currentBase = 1;
    }
}
