using UnityEngine;

public class w2player : MonoBehaviour
{

    private w2Health health;
    private w2Weapon weapon;

    public w2player(int vida, int damage)
    {

        health = GetComponent<w2Health>();
        weapon = GetComponent<w2Weapon>();

    }

    public void attack(w2Health enemigo)
    {

        weapon.Attack(enemigo);
    }
}



