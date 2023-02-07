using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boingboingquesigue : MonoBehaviour
{
    // Start is called before the first frame update
    public float RangodeVision;

    public LayerMask capadelJugador;
    public Transform Jugador;

    bool estarAlerta;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, RangodeVision, capadelJugador);

        if (estarAlerta == true)
        {
            transform.LookAt(Jugador);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, RangodeVision);
    }
}
