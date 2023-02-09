using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colectable : MonoBehaviour
{
    // tutoriales gringos, quien diria que acabaria aqui, si lo busco en un futuro es Collectable item mini unity tutorial, cachatela chikiwapi

    void Start()
    {

    }

    private void OnTriggerEnter (Collider other)
    {
       if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}