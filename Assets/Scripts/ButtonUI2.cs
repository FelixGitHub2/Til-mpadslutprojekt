using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI2 : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas;
    public void NewGameButton()
    {
        Canvas.SetActive(false);
    }

}