using UnityEngine;

public abstract class w4Entity : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int defense;

    public w4BaseStats baseStats = new w4BaseStats();

    public abstract void TakeDamage();

    public virtual void TakeDamage2()
    {

    }

    public abstract void DoDamage();


    public abstract void OnSpawn();

    public abstract void OnDead();



    public int Health => health;

}

