using UnityEngine;

//Script primarily for Player, but can be used in Enemies

public class w2Health : MonoBehaviour
{
    private int health = 20;
  //  private int maxHealth = 100;

    public w2Health(int vida) // este constructor nunca se ejecuta
    {
        Vida = vida;
    }

    public int Vida { get; }

    public void TakeDamage(int damageAmount)
    {
        if (damageAmount < 0) return;

        health -= damageAmount;

        if (health <= 0)
        {
            health = 0;
            Debug.Log(gameObject.name + "ha muerto");
        }
    }

    public void Heal(int healAmount)
    {
        if (healAmount < 0) return;
        health += healAmount;
    }
}

/*
{
    [SerializeField] Weapon weaponScript;

    [Header("Vida")]
    public int maxVida;   // 100% de vida
    public int vida;      // vida actual

    [Header("Estado")]
    public bool isDead = false;

    private void Start()
    {
        maxVida = vida;
    }

    public void TomarDamage()
    {
        if (isDead) { return; }
        vida -= weaponScript.damage;

        if (vida <= 0)
        {
            vida = 0;
            isDead = true;
            Destroy(gameObject);
        }
    }
}*/

