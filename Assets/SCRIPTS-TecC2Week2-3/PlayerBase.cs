using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("The name is : ..." + collision.gameObject.name);

        //Manera A
        collision.gameObject.GetComponent<Enemybase>().TakeDamage(1);

        //Manera B
        Enemybase enemy1 = collision.gameObject.GetComponent<Enemybase>();
        if (enemy1 != null)
            enemy1.TakeDamage(1);

        //Manera C
        
        if (collision.gameObject.TryGetComponent<Enemybase>(out Enemybase enemy2))
        {
            enemy2.TakeDamage(1);
        }

    }
}
