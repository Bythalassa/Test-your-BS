using UnityEngine;

// todo lo que no deriva de Monobehavior es cosiderado una Base de Datos

public class w3DamagePopupTxt : MonoBehaviour
{
    public string Text; 

    public w3DamagePopupTxt(string text)
    {
        Text = text; 
    }

    ~w3DamagePopupTxt() 
    {
        System.Console.WriteLine("Popup finalizado por el GC");
    }



}
