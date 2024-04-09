using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision : MonoBehaviour
{
    private bool isOn;

    [SerializeField]
    GameObject Canvas;

    [SerializeField]
    GameObject JoeText;

    [SerializeField]
    GameObject NoWayWall;

    [SerializeField]
    GameObject JoeSwan;

    [SerializeField]
    GameObject Cleveland_Brown;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cube")
        {
            Canvas.SetActive(true);
        }


        if (other.tag == "Cube2")
        {
            JoeText.SetActive(true);
        }

        if (other.tag == "NoWayWall")
        {
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "Enemy")
        {
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "Spawner")
        {
            JoeSwan.SetActive(true);
        }

        if (other.tag == "Spawner2")
        {
            Cleveland_Brown.SetActive(true);
        }


        if (other.tag == "JoeSwan")
        {
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "Cleve")
        {
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "Peter")
        {
            SceneManager.LoadScene("Game");
        }
        




    }



    // Update is called once per frame
    void Update()
    {

    }
}
