using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        Debug.Log("Upsies");
    }

}
