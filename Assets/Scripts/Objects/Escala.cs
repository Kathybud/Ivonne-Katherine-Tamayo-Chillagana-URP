using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3 (Random.Range (0.1f,1.0f), 1, Random.Range (0.1f, 1.0f));


    
    


    }
}
