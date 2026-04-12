using UnityEngine;

public class CommonWeapon : Weapon
{
    public override float GetDamage()
    {
        return GetBaseDamage();
    }
}
