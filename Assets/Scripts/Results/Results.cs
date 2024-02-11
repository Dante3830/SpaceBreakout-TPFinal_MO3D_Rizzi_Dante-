using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Results : MonoBehaviour
{
    // Referencia al TMPro que usará para mostrar el puntaje 
    public TextMeshProUGUI scoreTextMesh;

    void Start() {
        // Recupera el puntaje desde PlayerPrefs
        float finalScore = PlayerPrefs.GetFloat("finalScore");
        scoreTextMesh.text = finalScore.ToString();

        // Limpiar PlayerPrefs después de usarlo para evitar problemas en futuras partidas
        PlayerPrefs.DeleteKey("finalScore");
    }
}
