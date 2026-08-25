using UnityEngine;

//Script primarily for Player, but can be used in Enemies

public class Health : MonoBehaviour
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


}

