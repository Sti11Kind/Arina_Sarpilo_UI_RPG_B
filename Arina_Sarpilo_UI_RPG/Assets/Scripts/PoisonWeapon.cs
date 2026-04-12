using UnityEngine;

public class PoisonWeapon : Weapon
{
    public float poisonDamage;
    public int poisonCount;
    
    public override float GetDamage()
    {
        float damage = GetBaseDamage(); 

        if (poisonCount > 0)
        {
            poisonCount--;
            damage += poisonDamage;
            Debug.Log("Poison damage dealt! Charges remaining: " + poisonCount);
        }
        return damage;
    }
}
