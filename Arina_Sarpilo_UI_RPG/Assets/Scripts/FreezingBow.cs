using UnityEngine;

public class FreezingBow : Weapon
{
    [Header("Properties of bow")]
    [Range(0, 1)] public float freezeChance = 0.15f;
    public float freezeMultiplier = 1.3f;

    public override float GetDamage()
    {
        float damage = GetBaseDamage();
        damage *= freezeMultiplier;
        
        if (Random.value <= freezeChance)
        {
            Debug.Log("ICE SHOT! The enemy is frozen and has received: " + damage + " damage.");
        }
        else
        {
            Debug.Log("The bow shot struck: " + damage);
        }

        return damage;
    }
}
