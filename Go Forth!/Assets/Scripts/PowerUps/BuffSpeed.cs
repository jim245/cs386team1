using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Buffs/Speed")]
public class BuffSpeed : PowerUpEffect
{
    public float multiplier;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().speed += multiplier;
    }
}
