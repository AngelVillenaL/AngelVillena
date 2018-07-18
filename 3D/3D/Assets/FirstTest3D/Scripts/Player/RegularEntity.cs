using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularEntity : EnemyEntity {
	private void Update()
	{
        setRenderColor(colorIndex);
	}
}
