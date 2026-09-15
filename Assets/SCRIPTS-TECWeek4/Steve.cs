using UnityEngine;

public class w4Steve : w4Entity
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void TakeDamage(int damage)
    {
        throw new System.NotImplementedException();
    }
    protected override void AttackSmt(w4Entity entity)
    {
        throw new System.NotImplementedException();
    }

    protected override void OnDead()
    {
        throw new System.NotImplementedException();
    }

    //------------------------------------- private 
    public void Healing()
    {

    }

}
