using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    // Referencia al slider de brillo
    public Slider brightnessSlider;

    // Referencia al panel de brillo
    public Image brightnessPanel;

    // Valor del slider
    public float sliderValue;

    // Inicializa con el brillo preseteado
    void Start() {
        brightnessSlider.value = PlayerPrefs.GetFloat("brightness", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightnessSlider.value);
    }

    // El brillo luego puede ser ajustado por el jugador con el slider
    public void ChangeSlider(float value) {
        sliderValue = value;
        PlayerPrefs.SetFloat("brightness", sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightnessSlider.value);
    }
}
