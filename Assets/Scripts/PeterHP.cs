using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PeterHP : MonoBehaviour
{
    public int hp = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            hp--;
        }

    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Win");
        }
    }
}
