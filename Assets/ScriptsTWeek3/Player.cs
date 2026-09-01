using UnityEngine;

public class Player : MonoBehaviour
{

    public BaseStats Stats = new BaseStats();
    public WeaponData Weaponinfo = new WeaponData(8); //not usandolo aun 

    /*
    private void Awake()
    {
        //have an instance from BaseStats /-> 
        Stats.SetMaxMana(35);

        Stats.TakeDamage(10);


    }

    public void TakeDamage(int amount)
    {
        maxHealth -= amount;

        if (MaxHealth < 0)
        {
            EnemigoScript.Die();
        }
    }
    */
    public void Attack() 
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (var enemy in Enemies)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position)< 3)
            {
                
               // enemy.GetComponent<Enemy>().TakeDamage();
                
            }
        }
    }

   public void SetWeapon(WeaponData weapon) // funcion to enable player take Weapon and its values == Weaponsinfo, 
                                              // and could change to another weapon vielleicht
   {
        Weaponinfo = weapon;
   }
    



}
