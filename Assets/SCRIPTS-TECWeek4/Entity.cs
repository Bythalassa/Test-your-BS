using UnityEngine;

public abstract class w4Entity : MonoBehaviour
{
    private w4BaseStats stats;

    protected virtual void Awake()
    {
      stats = new(78, 8);
        //health - speed 


    }

    protected abstract void TakeDamage(int damage);
    protected abstract void AttackSmt(w4Entity entity);
    protected abstract void OnDead();



    public w4BaseStats Stats => stats;
}