using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Velocidad de movimiento del bate
    public float moveSpeed;

    // Límites del eje x
    public float minXLimit = -19f;
    public float maxXLimit = 24.5f;

    // Dirección del jugador
    private Vector3 direction;

    // Mueve el bate del jugador de izquierda a derecha
    private void Update() {

        // Si presiona izquierda, se mueve a la izquierda
        if (Input.GetKey(KeyCode.LeftArrow)) {
            direction = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            // Si presiona derecha, se mueve a la derecha
            direction = Vector3.right;
        }
        else {
            // De lo contrario, no se mueve
            return;
        }

        // Actualiza la posición del jugador
        transform.position = transform.position + direction * moveSpeed * Time.deltaTime;

        // Aplicar límites del eje x
        float clampedX = Mathf.Clamp(transform.position.x, minXLimit, maxXLimit);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
