using System.IO.Pipes;
using UnityEngine;

public class GameManagerExamples : MonoBehaviour
{
    void Start()
    {
        Son son = new Son(12, "Pipe");

        son.GrandFatherName = "Pipe";
        son.Shake();
        


    }


    public abstract class GrandFather
    {
        public string GrandFatherName;
        protected int health;
        protected int mana;

        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0) { health = 0; }
        }

        public abstract void UseAbility(int value);

        public virtual void Attack()
        {
            Debug.Log("Attack");
        }


        public int Health => health;
        public int Mana => mana;
    }

    public class Father : GrandFather
    {
        protected float velocity = 5;
        public override void UseAbility(int value)
        {
            //throw new System.NotImplementedException();
            Debug.Log("El poder cuesta" + value + "de mana");
        }

        public override void Attack()
        {
            base.Attack();
            Debug.Log("Attack2");
        }

        protected void Move()
        {
            Debug.Log("Las stats generales son" + velocity + GrandFatherName + health + Mana);
        }
    }

    public class Son : Father
    {
        public Son(int value, string value2) 
        {
        Debug.Log(value + value2);
        }

        public void Shake()
        {
            Move();
        }

    }

}


