using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (other.tag == "JoeSwan")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Cleve")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Peter")
        {
            Destroy(gameObject);
        }

    }

}
