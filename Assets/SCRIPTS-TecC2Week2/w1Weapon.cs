using UnityEngine;

public class w2Weapon : MonoBehaviour
{
    public int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<w2Health>(out w2Health targetHealth))
        {
            Attack(targetHealth);

            /* error phase
                 there is no argument given that corresponds to the required parameter target
                 EL CONTRATO -> necesita un script por lo tanto le damos un script? 
                 porque aqui necesito especificamente el valor targetHealth. */

            /*  1. out 
                Es un modificador que le dice a C# "este parámetro no se usa para 
                pasar un valor de entrada, sino para que el método me devuelva un valor
                a través de él". Es como un segundo "return", pero pasado como parámetro.
                
                y como se que esta regresando exactamente 

                2. targetHealth
                targetHealth no es una copia, ni un dato suelto: es una referencia directa
                al componente w2Health

                3. si ese GameObject en la escena tiene un w2Health con health = 20,
                targetHealth apunta exactamente a ese objeto en memoria -> la propiedad actual del enemy de health :_D
             */
        }
    }

    public void Attack(w2Health target)
    {
        target.TakeDamage(damage);
    }
}


/*
{
    private bool canAttack = false;
    public int damage = 7;
     

    private void On CollisionEnter(Collision collision)
    {
        if (canAttack)
        {
            if (collision.gameObject.TryGetComponent<Health>(out Health vida))
            {
                vida.TomarDamage();
            }
        }
    }
}
*/
