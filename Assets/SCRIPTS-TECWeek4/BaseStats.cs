using UnityEngine;

/*
 * InClassExercise DoiTSimple solo a base de debug.log (el concepto del atack etc)
 * 
 * abstract es una palabra clave (no tiene otra denominación solo palabra clave)
 * 
 * base.metodo (toda la direccion de padre )
 * 
// solo a base de debug.log (el concepto del atack etc)
//Se usa abstract para evitar usar clases en el hierarchy
// public virtual void Name --->  Metodos flexibles que pueden cambiar 
*/
public class w4BaseStats
{
    private int health;
    private int damage;
    private int speed;

    public w4BaseStats(int _health, int _damage, int _speed)
    {
        health = _health;
        damage = _damage;
        speed = _speed;
    }


    public int Health => health;
    public int Damage => damage;
    public int Speed => speed;
}