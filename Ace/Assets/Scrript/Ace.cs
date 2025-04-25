using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ace : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vc = Input.acceleration;
        vc= Quaternion.Euler(90,0,0)*vc;
        rb.AddForce(vc*speed);

    }
}
