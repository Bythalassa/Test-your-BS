using UnityEngine;

// todo lo que no deriva de Monobehavior es cosiderado una Base de Datos

public class BaseData

{
    public string UserName;


    /// <summary>
    /// un metodoo llamado BaseData
    /// </summary>
    public BaseData(string _userName, int _damage) //-> construct 
    {
        Debug.Log("hOLA");
        UserName = _userName; 
    }

    ~BaseData()
    {
        Debug.Log("byes");
    }




}

