using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldArmor : IArmor
{
    private readonly int _strength;

    public ShieldArmor(int strength)
    {
        _strength = strength;
    }

    public int ReduceDamage(int damage)
    {
        int reducedDamage = damage - _strength;

        return (reducedDamage > 0) ? reducedDamage : 0;
    }
}
