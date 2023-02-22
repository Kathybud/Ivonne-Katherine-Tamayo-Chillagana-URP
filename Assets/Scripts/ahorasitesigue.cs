using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ahorasitesigue : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    // me re mama que dos lineas resuman mi dolor de 40
    void Update()
    {
        nav.SetDestination(target.position);
    }
}
