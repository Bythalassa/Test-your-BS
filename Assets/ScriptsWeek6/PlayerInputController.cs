using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public InputSystem_Actions inputs;
    //waaa revisar el miro mañana 8am

    private void Awake()
    {
        inputs = new();

    }

    private void OnEnable()
    {
        Debug.Log("Habilitado");
       
    }





    void Start()
    {
        
    }

 






}
