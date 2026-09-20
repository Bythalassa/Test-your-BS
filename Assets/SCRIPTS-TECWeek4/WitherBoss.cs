using UnityEngine;

public class w4WitherBoss : w4Zombie
{
    public w4BaseStats basestats;
    private int actualHealth;



    protected override void Awake()
    {
        base.Awake();
    }
    
     //actualHealth = basestats.Health


    protected override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

         actualHealth = basestats.BaseHealth;

        damage -= actualHealth; 

        if (actualHealth >= 0)
        {
            actualHealth = 0;
        }

        if (actualHealth >= 0) //* add percentage 4 week 5
        {
            actualHealth = 0;
        }




    }







}
