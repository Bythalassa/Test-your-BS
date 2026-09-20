using UnityEngine;

/* Error ccessibility field type "DamageType" is less accessible than field "name" w4Steve.damagetype
 * fix: Ambos "enum" y "referencia" tienen que ser del mismo acceso. Un miembro nunca puede ser más accesible que su tipo. */
public enum DamageModifier
{ 
 none,
 Might,
 Area,
 Amount
}

public class w4Steve : w4Entity
{
    public DamageModifier damageModifier;
    public DamageEffect damageeffect;


    protected override void Awake()
    {
        base.Awake();
        Healing();
    }

    protected override void TakeDamage(int damage)
    {
        throw new System.NotImplementedException();
    }

    protected override void AttackSmt(w4Entity entity)
    {
        //esto es core para el attack
        //Ataque automatico, vinculado al if else currentWeapon == WeaponNable is available
        //entonces apply Damage Modifier

        // empezar a vincular el modifier type con su formula

        switch (damageModifier)
        {
            case DamageModifier.none:

                Debug.Log("You have not aquired a weapon with a modifier of Damage, " +
                    "altough perhaps you have another type of modifier such as " +
                    "Armor, Recovery, Cooldown, Speed, Duration, Charm, Greed, Growth, etc");
                break;
            case DamageModifier.Might:
                /*Multiplica de forma porcentual el daño base de absolutamente todas sus armas.  */
                /*  */
                /*   */



                break;
            case DamageModifier.Area:
                /*  */

                break;
            case DamageModifier.Amount:
                /*  */
                
                break;

        }
        
    }

    protected override void OnDead()
    {
        throw new System.NotImplementedException();
    }

    //------------------------------------- private 
    private void Healing()
    {

    }

}
