using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BaseStats Stats = new BaseStats();
    public WeaponData Weaponinfo = new WeaponData(3); //parametro de damage

    // public current health == maxhealth
    // usar current Health en takeDamage
    /*
    private void Awake()
    {
        //have an instance from BaseStats /-> 
        Stats.SetMaxHealth(25);
        
        Stats.TakeDamage(10);

    }

    public void TakeDamage(WeaponData data)
    {
        maxHealth -= data.we;

        if (MaxHealth < 0)
        {
            EnemigoScript.Die();
        }
    }
    */

    public void Die()
    {
        Debug.Log("Enemy is Dead");
        Destroy(gameObject);

    }
    private void OnDestroy()
    {
        //todo lo que ocurre on Destroy 
        Debug.Log("Unity destruyo este Game Object");
    }


}
