using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Velocidad de la bola
    public float speed = 300;

    // Referencia al Rigidbody de la bola
    public Rigidbody _rigidbody;

    // Movimiento de la bola
    private Vector3 velocity;

    // Posición inicial de la bola
    private Vector3 startPosition;

    // Referncia al Audio Source de la bola
    public AudioSource audioSource;

    // Clips de sonido para el jugador, ladrillos, paredes y zona muerta
    public AudioClip playerSound, brickSound, wallSound, deadSound;

    // Inicializa con la posición inicial lanzando la bola
    void Start() {
        startPosition = transform.position;
        ResetBall();
    }

    // Si la bola colisiona con...
    private void OnCollisionEnter(Collision collision) {

        //...la zona muerta, pierde una vida
        if (collision.gameObject.CompareTag("DeadZone")) {
            FindObjectOfType<GameManager>().LooseBall();

            // Hacer sonar clip de sonido de zona muerta
            audioSource.clip = deadSound;
            audioSource.Play();

        } else if (collision.gameObject.CompareTag("Brick")) {
            //...un ladrillo, suma puntos al puntaje
            FindObjectOfType<GameManager>().WinPoints();

            // Hacer sonar clip de sonido de ladrillo
            audioSource.clip = brickSound;
            audioSource.Play();

        }
        else if (collision.gameObject.CompareTag("Player")) {
            // Hacer sonar clip de sonido de jugador
            audioSource.clip = playerSound;
            audioSource.Play();
        }
        else if (collision.gameObject.CompareTag("Wall")) {
            // Hacer sonar clip de sonido de pared
            audioSource.clip = wallSound;
            audioSource.Play();
        }

    }

    // Resetear la bola para que se lanze desde su punto inicial
    public void ResetBall() {
        transform.position = startPosition;
        _rigidbody.velocity = Vector3.zero;
        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1;
        _rigidbody.AddForce(velocity * speed);
    }

}