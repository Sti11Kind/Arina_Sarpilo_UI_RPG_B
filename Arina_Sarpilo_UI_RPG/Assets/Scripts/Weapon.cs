using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string weaponName;
    [SerializeField] protected float minDamage, maxDamage;
    public float GetBaseDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }
    public abstract float GetDamage();
}
