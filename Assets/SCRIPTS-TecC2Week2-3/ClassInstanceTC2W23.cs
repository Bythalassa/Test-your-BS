using Unity.VisualScripting;
using UnityEngine;

public class ClassInstanceTC2W23 : MonoBehaviour
{
    void Start()
    {
        Enemy skull = new Enemy();
        skull.EnemyName = "Skull";
        skull.Hp = 8;

        Enemy witch = new Enemy();
        witch.EnemyName = "Witch";
        witch.Hp = 50;
    }

    public class Enemy
    {
        public string EnemyName;
        public float Hp;
        
        public void TakeDamage(float damage)
        {
            Hp -= damage;
        }

        public void Death()
        {
            if (Hp >= 0f)
            {
                Destroy(gameObject);
            }
        }



}
