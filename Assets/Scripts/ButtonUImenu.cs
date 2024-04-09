using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUImenu : MonoBehaviour
{
    [SerializeField] private string Game = "Game";
    public void NewGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    
}
