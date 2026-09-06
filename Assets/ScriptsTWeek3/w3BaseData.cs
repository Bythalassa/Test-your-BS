using UnityEngine;

// todo lo que no deriva de Monobehavior es cosiderado una Base de Datos

public class w3BaseData

{
    public string UserName;


    /// <summary>
    /// un metodoo llamado BaseData
    /// </summary>
    public w3BaseData(string _userName, int _damage) //-> construct 
    {
        Debug.Log("hOLA");
        UserName = _userName; 
    }

    ~w3BaseData()
    {
        Debug.Log("byes");
    }




}

