using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Enemybase : MonoBehaviour
{
    public int health = 10;
    public bool IsDead;

    void Start(){
        TakeDamage(7);
    }

    public void TakeDamage() //Metodo Simple
    {
        health -= 1;

        if (health < 0)
        {
            health = 0;
            IsDead = true;
            Debug.Log("El jugador a muerto");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        OnHit();

        //vfx Damage


        if (health <= 0)
        {
            health = 0;
            IsDead = true;
            Debug.Log("El jugador a muerto");
        }
    }

    public void OnHit() {
        //-> Sistema de particulas de daño
        //-> Sonido de Golpe
        //-> Luces
        //-> camara Shake
    }
}


