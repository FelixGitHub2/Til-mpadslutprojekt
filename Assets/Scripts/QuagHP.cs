using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuagHP : MonoBehaviour
{
    public int hp = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            hp--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
