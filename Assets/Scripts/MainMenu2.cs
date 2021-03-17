using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public bool ready = false;

    public void PlayGame2()
    {
        ready = true;
    }

    public void QuitGame2()
    {
        Application.Quit();
    }
}