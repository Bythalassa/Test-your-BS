using Unity.VisualScripting;
using UnityEngine;

public class FeelTopdownPlayer : MonoBehaviour
{

    private FeelBaseStaats stats;

    protected virtual void Awake()
    {
        stats = new(70, 8, 6);
    }

    void Update()
    {
        CanMove();

        if (Input.GetKeyDown(KeyCode.E)) { CanMeleeAttack(); }
        if (Input.GetKeyDown(KeyCode.Q)) { CanShot(); }
     
    }

    private void CanMove()
    {
        //erst verkommt beides axis 
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //asigna x y axis (Input) al vector de direction
        Vector3 direction = new Vector3(x, y, 0);
        //normalize it
        direction.Normalize();

        //suma e iguala los valores real tie en transform.position a la dirección x Speed x Time
        transform.position += direction * stats.BaseSpeed * Time.deltaTime;
    }

    /*  Estructura de la función de Atacar: 
    
    public Enemy defaultTarget; eso es el script de enemy whatttt

    La referencia de que es player no esta optimizado --> 
    ---> Hasta lo que yo estaba acostumbrado a hacer es se lo pasa un Tag
    !!! Lo optimizado es Que pase la pase quien lo crea, (un spawner(?)??)??) 
    en un Initialize(Player objetivo) 

    
     if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack(defaultTarget);
        }
    
     public void Attack(Enemy target) // ojo con la referencia del Enemy {  } */


    private void CanMeleeAttack()
    {
       

    }

    private void CanShot()
    {
        

        //Input.mouse
        Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePos - transform.position);
        direction.z = 0;
        direction.Normalize();


        /*if(Input.GetMouseButtonDown(0))
        {
          GameObject bullet = Instantiate(/*BulletPrefab ,  transform.position,Quaternion.identity);   
          bullet.transform.up = direction;
        } */

    }
}
