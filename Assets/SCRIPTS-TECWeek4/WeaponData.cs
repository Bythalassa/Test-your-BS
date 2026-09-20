using UnityEngine;


public enum DamageEffect
{
    none,
    Ice,
    Fire,
    Ralentizacion
}

public abstract class w4WeaponStats : MonoBehaviour
{

    private void Start()
    {
        ApplyDamageEffect();
    }

    public DamageEffect damageEffect;

    private int base_damage;
    private int base_area;
    private int base_amount;

    //instanciar en public clases weapon x name
    public w4WeaponStats(int _base_damage, int _base_area, int _base_amount, DamageEffect _damageEffect, bool isAvailable)
    {
        base_damage = _base_damage;
        base_area = _base_area;
        base_amount = _base_amount;
    }


    private void ApplyDamageEffect()
    {
        switch (damageEffect)
        {

            case DamageEffect.none :
                Debug.Log("no effect applied, maybe no weapon with an effect is selected");
                break;

            case DamageEffect.Ice :
                //






                break;

            case DamageEffect.Fire:

                break;

            case DamageEffect.Ralentizacion:

                break;

        }
    }

    public int BaseDamage => base_damage;
    public int BaseArea => base_area;
    public int BaseAmount => base_amount;


}

// W E A P O N S
// Base damage, Base area, Base amount, ice - fire - Ralentizacion
// posible futuro: que damage aplica, esto se da x input de arma, weapon available

public class WepIcebrand
{
    // initWeaponStats -> Icebrand(DLC Castlevania) : 10, 100%, 1, ICE: Dispara proyectiles que congelán a enemigos.



}


public class WepGarlic
{
    // initWeaponStats-> Garlic : 5, 100% , 1 ,  Fire: Los enemigos golpeados reciben más knockback (+0.3 por golpe)




}


public class WepMannajja
{
    // initWeaponStats-> Mannajja (evolución de Song of Mana) : 40, 6 (+325%), 1, Ralentización : Los enemigos golpeados que sobreviven quedan ralentizados de forma permanente. 




}