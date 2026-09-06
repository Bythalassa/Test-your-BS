using UnityEngine;

public class w3WeaponData
{
    private int damage = 3;
    public int Damage=> damage;

    public void SetDamage(int _nuevoDamage)
    {
        damage = _nuevoDamage;
    }
    public w3WeaponData(int _damage) //-> construct 
    {
        damage = _damage;
    }


}
