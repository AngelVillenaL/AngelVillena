using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect  {


    protected Color color;
    protected string name;
    public string componentName { get { return name;  }}

    protected Effect () {
        
    }

    static public Effect CreateEmpty () {
        Effect effect = new Effect();
        effect.name = "None";
        return effect;
    }
      
    public Effect Apply (EnemyEntity enemyEntity) {
        OnApply(ref enemyEntity);
        return this;
    }

    public virtual bool Update (float frameDelta) {
        return true;
    }


    public virtual void OnApply(ref EnemyEntity enemyEntity)
    {
        
    }
}
