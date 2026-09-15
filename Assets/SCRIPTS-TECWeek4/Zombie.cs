
using UnityEngine;

public class w4Zombie : w4BaseEnemy
{
    protected override void Awake()
    {
        base.Awake();
        EvolutionZ();
    }
    protected override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    protected override void AttackSmt(w4Entity entity)
    {
        base.AttackSmt(entity);
        Debug.Log("hago cierto daño y enveneno");
    }
    protected override void OnDead()
    {
        base.OnDead();
        Debug.Log("suelto carne podrida");
    }
    protected override void ChaseEntity(w4Entity entity)
    {
        base.ChaseEntity(entity);
        Debug.Log("Mientras grito wahhh");
    }

    private void EvolutionZ()
    {
        Debug.Log("Cuando me equipan con armadura especial de zombie EVOLUCIONO");
    }




}