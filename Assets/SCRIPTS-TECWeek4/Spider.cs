using UnityEngine;
public class w4Spider : w4BaseEnemy
{
    protected override void Awake()
    {
        base.Awake();
        EvolutionS();
    }
    protected override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    protected override void AttackSmt(w4Entity entity)
    {
        base.AttackSmt(entity);
        Debug.Log("empujo al atacar");
    }
    protected override void OnDead()
    {
        base.OnDead();
        Debug.Log("suelto tela de araña");
    }
    protected override void ChaseEntity(w4Entity entity)
    {
        base.ChaseEntity(entity);
        Debug.Log("salto mientras digo pssst");
    }

    private void EvolutionS()
    {
        Debug.Log("Cuando me tiran posiones de crecimiento EVOLUCIONO");
    }
}