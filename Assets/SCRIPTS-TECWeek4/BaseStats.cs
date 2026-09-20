using UnityEngine;

 /*InClassExercise DoiTSimple solo a base de debug.log (el concepto del atack etc)
 * 
 * abstract es una palabra clave (no tiene otra denominación solo palabra clave)
 * --> Moreover,evitar usar clases en el hierarchy. Y mantener un lindo ecosistema de scripts.
 * base.metodo (toda la direccion de padre ) */


public class w4BaseStats
{
    private int base_health;
   // private int base_damage;
    private int base_speed;

    public w4BaseStats(int _base_health, int _base_speed)
    {
        base_health = _base_health;
    //    base_damage = _base_damage;
        base_speed = _base_speed;
    }


    public int BaseHealth => base_health;
    //public int BaseDamage => base_damage;
    public int BaseSpeed => base_speed;
}