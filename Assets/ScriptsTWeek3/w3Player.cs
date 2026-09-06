using UnityEngine;


public class w3Player : MonoBehaviour
{
    public w3Enemy w3EnemyScript; 
    public w3BaseStats PlayerStats;
    public w3WeaponData PlayerWeaponOneinfo;  //

    private int DamageDospuntoceroreferencial;
    private int PlCurrentHealth; 

    void Awake()
    {
        PlayerStats = new w3BaseStats(40, 35);
        PlayerWeaponOneinfo = new w3WeaponData(8);
    }

    public void SetAnotadorTresPC()
    {
        DamageDospuntoceroreferencial = w3EnemyScript.EnemyWeaponOneinfo.Damage;
    }



    public void PlTakeDamage()
    {
        if (PlCurrentHealth > 0)
        {
            PlCurrentHealth -= DamageDospuntoceroreferencial;
        }

        else if (PlCurrentHealth <= 0)
        {
            PlCurrentHealth = 0;
            Die();
        }
    }


    public void Die()
    {
        Debug.Log("Player is Dead");
        Destroy(gameObject);
    }

    public void SetWeaponGun(w3WeaponData _weaponData)
    {
        PlayerWeaponOneinfo = _weaponData;
        // funcion to enable player take Weapon and its values == Weaponsinfo, 
        // and could change to another weapon vielleicht
    }

    public void Attack() 
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (var enemy in Enemies)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position)< 3)
            {

                // enemy.GetComponent<Enemy>().EneTakeDamageManager();
                //aqui activa el managerdel take damage

            }
        }
    }

    
}



