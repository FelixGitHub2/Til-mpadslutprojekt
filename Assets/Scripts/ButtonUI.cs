using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string Combat = "Combat";
    public void NewGameButton()
    {
        SceneManager.LoadScene("Combat");
    }
    
}
