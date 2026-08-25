using UnityEngine;

public class KPLMovement : MonoBehaviour
{
    //No creo que importe como mueva al player por ahora. 
    //Usando transform por ahora

    private Rigidbody2D rb;

    public float speed;
    public Vector2 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveDir = 
            new Vector2(
            Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical")
            ).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDir * speed;
        // cs: Muévete en la dirección moveDir, a esta velocidad (speed)".
        // motor mediante el wrapper de RG 2D: get value FixedUpdate.
    }

    /* Alternativas a la función de moverse actualmente que aún no conozco :

  rb.AddForce(moveDir * speed); 
    Pero acá sí notás una diferencia real: el objeto va a tener inercia 
    (sigue deslizando un poco después de soltar la tecla, tarda en frenar/acelerar)

    AddForce le suma una fuerza a un acumulador. 
    Esa fuerza se convierte en aceleración (según la masa: F = m * a),
    y la aceleración cambia la velocidad gradualmente a lo largo del tiempo.

  rb.MovePosition(rb.position + moveDir * speed * Time.fixedDeltaTime);
    Funciona mejor si el Rigidbody2D está configurado como Kinematic

  rb.linearVelocity
    linearVelocity ignora la masa y las fuerzas acumuladas, y fuerza la velocidad a 
    ser exactamente el valor que le diste, de una. No hay "proceso" de aceleración, es instantáneo.

    */

    /* Como funciona Rigidbody2D y rb.linearVelocity : 
      RG (2D) es un Wrapper/envoltorio que se comunica con el motor de Física escrito en C++
      (Unity usa Box2D para físicas 2D).s

    rb.linearVelocity = moveDir * speed;

    1.- El set de la propiedad se ejecuta.
    2.- Ese código en C# llama a una función nativa en C++ (a través de bindings/marshaling).
    3.- El motor de física en C++ actualiza el estado real del cuerpo rígido en su simulación interna.

    Y cuando leés rb.linearVelocity, pasa lo inverso: 
    el get le pregunta al motor de física en C++ "¿cuál es la velocidad actual de este cuerpo?" 
    y te devuelve ese valor.
    */

}