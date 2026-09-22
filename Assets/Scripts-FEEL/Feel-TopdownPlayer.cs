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
        CanAttack();
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

       // BaseSpeed = 

        //suma e iguala los valores real tie en transform.position a la dirección x Speed x Time
        transform.position += direction * stats.BaseSpeed * Time.deltaTime; 
    }

    private void CanAttack()
    {


    }



}
