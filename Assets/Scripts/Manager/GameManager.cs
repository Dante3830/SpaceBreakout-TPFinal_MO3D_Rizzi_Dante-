using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Vidas durante el juego
    public float lives = 3;

    // Puntos durante el juego
    public float points = 100;

    // Texto de las vidas
    public TextMeshProUGUI livesTextMesh;

    // Texto del puntaje
    public TextMeshProUGUI scoreTextMesh;

    // Game object con todos los ladrillos
    public GameObject gameBricks;

    // Puntos durante el juego
    private float score = 0;

    // Actualiza el estado del juego
    private void Update() {
        livesTextMesh.text = lives.ToString();
        scoreTextMesh.text = score.ToString();

        // Si el objeto con todos los ladrillos no tiene hijos...
        if (gameBricks.transform.childCount <= 0) {
            // ...setea el puntaje actual como final y pasa a la escena de victoria
            PlayerPrefs.SetFloat("finalScore", score);
            SceneManager.LoadScene("Victory");
        }
    }

    // Sacar una vida
    public void LooseBall() {
        lives--;

        // Si se le acaban las vidas...
        if (lives <= 0) {
            // ...setea el puntaje actual como final y pasa a la escena de derrota
            PlayerPrefs.SetFloat("finalScore", score);
            SceneManager.LoadScene("GameOver");
        } else {
            // De lo contrario, vuelve a lanzar la bola
            ResetLevel();
        }
    }

    // Suma los puntos al puntaje
    public void WinPoints() {
        score += points;
    }

    // Vuelve a lanzar la bola
    public void ResetLevel() {
        FindObjectOfType<Ball>().ResetBall();
    }

}
