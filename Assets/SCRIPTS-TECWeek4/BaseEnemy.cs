using UnityEngine;

public abstract class w4BaseEnemy : w4Entity
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void TakeDamage(int damage)
    {
        Debug.Log("ouch");
    }

    protected override void AttackSmt(w4Entity entity)
    {
        Debug.Log("ataque base");
    }

    protected override void OnDead()
    {
        Debug.Log("no dropeo nada");
    }

    protected virtual void ChaseEntity(w4Entity Wentity)
    {
        Debug.Log("Ven aqui pibble");
    }
}