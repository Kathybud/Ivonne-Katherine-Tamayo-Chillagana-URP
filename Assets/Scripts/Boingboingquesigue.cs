using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boingboingquesigue : MonoBehaviour
{
    // Start is called before the first frame update
    public float RangodeVision;

    public LayerMask capadelJugador;
    public Transform Jugador;
    public float Velocidad;

    bool estarAlerta;
  

    void Start()
    {
        
    }

    // Physics 
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, RangodeVision, capadelJugador);

        if (estarAlerta == true)
        {
            // Era ejemplo trucho pero dale que si funciona, transform.LookAt(Jugador);

            transform.LookAt(new Vector3(Jugador.position.x, transform.position.y, Jugador.position.z));

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Jugador.position.x, transform.position.y, Jugador.position.z), Velocidad * Time.deltaTime);
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, RangodeVision);
    }
}
