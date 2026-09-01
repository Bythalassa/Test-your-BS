using UnityEngine;

// todo lo que no deriva de Monobehavior es cosiderado una Base de Datos

public class DamagePopupTxt : MonoBehaviour
{
    public string Text; 

    public DamagePopupTxt(string text)
    {
        Text = text; 
    }

    ~DamagePopupTxt() 
    {
        System.Console.WriteLine("Popup finalizado por el GC");
    }



}
