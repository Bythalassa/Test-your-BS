using UnityEngine;

public class w3Enemy : MonoBehaviour
{
    public w3BaseStats EnemyStats;
    public w3WeaponData EnemyWeaponOneinfo;

    private int DamageDospuntoceroreferencial;

    public int EneCurrentHealth;
    public w3Player w3PlayerScript;


    private void Awake()
    {
        EnemyStats = new w3BaseStats(120, 90);
        EnemyWeaponOneinfo = new w3WeaponData(7);
    }

    private void Start()
    {
        EneCurrentHealth = EnemyStats.MaxHealth;
        //quiero debugear cuanto sale esto, si fue mod x la instancia
        //creada en el script, ya que supuestamente la var es privada de escritura y solo c puede cambiar por el metodo especial
        //check si la instancia de _max_health sirve 

    }

    public void SetAnotadorDosPC()
    {
        DamageDospuntoceroreferencial = w3PlayerScript.PlayerWeaponOneinfo.Damage;
    }


    public void EneTakeDamage()
    {
        if (EneCurrentHealth > 0)
        {
            EneCurrentHealth -= DamageDospuntoceroreferencial;
        }

        else if (EneCurrentHealth <= 0)
        {
            EneCurrentHealth = 0;
            Die();

        }
    }

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






