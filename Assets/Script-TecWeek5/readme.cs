using UnityEngine;

public class readme
{
    /*
     
    Diagrama de Clases con el simbolo de herencia (remake)


    Hitos base
    done |1  Jerarquía de entidades en tres niveles
    reorganizar las entidades en una jerarquía de herencia de varios niveles:
    
    ACTUAL
    Entidades: Steve
    BaseEnemy: Creeper, Spider, Zombie

    (done)Entity → Enemy → tipos de enemigo, con Player heredando directamente de Entity.
    
    Los atributos que usan las hijas pasan a protected;+
    Los metodos que hereda Entity:
    
    protected abstract void TakeDamage(int damage);
    protected abstract void AttackSmt(w4Entity entity);
    protected abstract void OnDead()   
    protected override void ChaseEntity(w4Entity entity)
    
    los que solo usa la propia clase siguen private.
    //Evolucion x enemy

    Ningún tipo de enemigo repite código que ya esté en Enemy o en Entity. 
    El README incluye el diagrama de clases con la flecha de herencia

    done | 3  Inicialización heredada
    stats (health-damage-speed)
    Entity inicializa lo común en un protected virtual void Awake();
    la hija que necesite algo propio lo amplía con override y base.Awake().
    Ninguna entidad puede quedar con su BaseStats sin inicializar: comprobarlo por consola al empezar la partida.


    en proceso |4 
    El jefe: extender, no reemplazar
    Crear un Boss que herede de uno de los enemigos existentes (tercer nivel de la jerarquía).
    Su TakeDamage() reutiliza el del padre con base.TakeDamage()
    y añade una segunda fase: al bajar del 50% de vida cambia su velocidad o su daño.
    Marcar el Boss como sealed y justificar en el README por qué nadie debería heredar de él.




    */

}
