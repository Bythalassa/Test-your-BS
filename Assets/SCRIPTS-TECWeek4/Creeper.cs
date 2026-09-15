using UnityEngine;
public class w4Creeper : w4BaseEnemy
{
    protected override void Awake()
    {
        base.Awake();
        EvolutionC();
    }

    protected override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    protected override void AttackSmt(w4Entity entity)
    {
        base.AttackSmt(entity);
        Debug.Log("exploto");
    }
    protected override void OnDead()
    {
        base.OnDead();
        Debug.Log("suelto polvora");
    }
    protected override void ChaseEntity(w4Entity entity)
    {
        base.ChaseEntity(entity);
        Debug.Log("en silencio!");
    }

    //add privates
    private void EvolutionC()
    {
        Debug.Log("Cuando cae un rayo sobre mi EVOLUCIONO");
    }

}