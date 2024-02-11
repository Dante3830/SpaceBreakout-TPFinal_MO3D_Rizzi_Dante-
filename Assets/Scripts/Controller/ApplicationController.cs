using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationController : MonoBehaviour
{
    // Abre la escena del menú principal
    public void LoadMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    // Abre la escena de juego
    public void LoadGame() {
        SceneManager.LoadScene("GameScene");
    }

    // Abre la escena de créditos
    public void LoadCredits() {
        SceneManager.LoadScene("Credits");
    }

}
