using UnityEngine;

public class Enemyweek7 : MonoBehaviour
{


    public void ApplyStatus(StatusEffect effect)
    {
        Debug.Log("Enemigo recibe :" + effect);
    }
    public void ApplyStatus(StatusEffect effect, float duration)
    {
        Debug.Log("Enemigo recibe :" + effect + "Time: " + duration);
    }
}