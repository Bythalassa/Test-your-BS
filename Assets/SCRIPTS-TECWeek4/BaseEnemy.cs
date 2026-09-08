using UnityEngine;

public class w4BaseEnemy : w4Entity
{

    public override void TakeDamage() {
    
        Debug.Log("hola");
    }








    public void MyDamage()
    {
        Debug.Log(Health + health);
    }

    public override void DoDamage()
    {

    }


    public override void OnSpawn()
    {

    }

    public override void OnDead()
    {

    }
}
