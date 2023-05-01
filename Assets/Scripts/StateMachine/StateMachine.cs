using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public MonoBehaviour WalkState;
    public MonoBehaviour RunState;
    public MonoBehaviour IdleState;

    private MonoBehaviour estadoActual;

    void Start()
    {
        
    }

   
}
