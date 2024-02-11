using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantObjects : MonoBehaviour
{
    // Los objetos que estén adentro del I.O. no serán destruidos al pasar a otra escena
    private void Awake() {

        var doNotDestroyBetweenScenes = FindObjectsOfType<ImportantObjects>();

        if (doNotDestroyBetweenScenes.Length > 1) {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
