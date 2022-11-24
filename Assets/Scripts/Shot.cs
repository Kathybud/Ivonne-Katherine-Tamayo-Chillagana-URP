using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bala;
    public Transform spwanPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time>shotRateTime)
            {
                GameObject newBala;
                newBala = Instantiate(bala, spwanPoint.position, spwanPoint.rotation);

                newBala.GetComponent<Rigidbody>().AddForce(spwanPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBala, 2);
            }
        }
    }
}
