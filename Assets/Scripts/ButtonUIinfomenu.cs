using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonUIinfomenu : MonoBehaviour
{
    [SerializeField] private string Menu = "Menu";
    public void NewGameButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
