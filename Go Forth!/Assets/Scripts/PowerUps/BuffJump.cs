using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Buffs/Jump")]
public class BuffJump : PowerUpEffect
{
    public float multiplier;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().jumpForce += multiplier;
    }
}
