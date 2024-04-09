using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonUIinfo : MonoBehaviour
{
    [SerializeField] private string Info = "Info";
    public void NewGameButton()
    {
        SceneManager.LoadScene("Info");
    }
}
