using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    // Referencia al slider de volúmen
    public Slider volumeSlider;

    // Valor del slider
    public float sliderValue;

    // Inicializa con el volumen preseteado
    void Start() {
        volumeSlider.value = PlayerPrefs.GetFloat("audioVolume", 0.5f);
        AudioListener.volume = volumeSlider.value;
    }

    // El volumen luego puede ser ajustado por el jugador con el slider
    public void ChangeSlider(float value) {
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = volumeSlider.value;
    }
}
