using UnityEngine;

public class Weapon : MonoBehaviour
{
    private bool canAttack = false;
    public int damage = 7;
     

    private void OnCollisionEnter(Collision collision)
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
