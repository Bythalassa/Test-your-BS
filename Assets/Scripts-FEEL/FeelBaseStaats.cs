using UnityEngine;

public class FeelBaseStaats 
{
    private int base_health;
    private int base_damage;
    private int base_speed;


    public FeelBaseStaats(int _base_health, int _base_damage, int _base_speed )
    {
        base_health = _base_health;
        base_damage = _base_damage;
        base_speed = _base_speed;

    }

    public int BaseHealth => base_health;
    public int BaseDamage => base_damage;
    public int BaseSpeed => base_speed;





}
