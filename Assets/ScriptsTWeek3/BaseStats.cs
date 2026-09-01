
using UnityEngine;

//-> vars
//--> MaxHealth
//--> maxMana
public class BaseStats
{
    
    private int maxHealth = 10;

    public void SetMaxHealth(int health) //Ejemplo de Metodo para Health
    {
        maxHealth = health;
    }
    public int MaxHealth => maxHealth; //unicamente public lectura y privado de escritura 




    private int maxMana = 5;
    public void SetMaxMana(int mana)
    {
        maxMana = mana;
    }
    public int MaxMana => maxMana; //unicamente public lectura y privado de escritura 
                                   // El puntero es un simbolo que escribe el tipo de contenedor que usa la "variable Anotador",
                                   // La Variable Anotador 










}
