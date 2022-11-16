using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {
        float step = Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step * speed);
    }

}