using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Controles (string Controles)
    {
        SceneManager.LoadScene(Controles);
    }
}
