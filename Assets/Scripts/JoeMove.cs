using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeMove : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = -transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
