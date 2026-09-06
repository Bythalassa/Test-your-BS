using UnityEngine;

//-> vars
//--> MaxHealth
//--> maxMana
public class w3BaseStats
{
    private int maxHealth = 10;
    private int maxMana = 5;

    public w3BaseStats(int _max_health, int _max_mana) //-> construct 
        /*le paso el mana y el Maxhealth para que use publicamente en un construct desde Player y Enemy*/
    {
        maxHealth = _max_health;
        maxMana = _max_mana;
    }

    public void SetMaxHealth(int health) //Ejemplo de Metodo para Health
    {
        maxHealth = health;
    }
    public int MaxHealth => maxHealth; //unicamente public lectura y privado de escritura 

    public void SetMaxMana(int mana)
    {
        maxMana = mana;
    }
    public int MaxMana => maxMana; // unicamente public lectura y privado de escritura 
                                   // El puntero es un simbolo que escribe el tipo de contenedor que usa la "variable Anotador",
                                   // La Variable Anotador 

}




