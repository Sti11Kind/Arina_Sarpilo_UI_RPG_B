using UnityEngine;

public abstract class Character : MonoBehaviour
{
    
    [SerializeField] private float health; 
    public float Health
    {
        get 
        { 
            return health; 
        }
        set 
        { 
            if (value < 0) 
            {
                health = 0;
            }
            else 
            {
                health = value;
            }
            
            Debug.Log(charName + " health now: " + health);
        }
    }
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);
    
    public void TakeDamage(float damage)
    {
        Health = Health - damage;
        Debug.Log(charName + " got hit for " + damage + " damage! " + "current Health: " + health);
    }

    public void TakeDamage(Weapon weapon)
    {
        float damage = weapon.GetDamage();
        TakeDamage(damage);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
