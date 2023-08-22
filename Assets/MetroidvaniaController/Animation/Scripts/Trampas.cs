using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Aqu� puedes agregar la l�gica para aplicar la trampa
            // Por ejemplo, reiniciar el nivel o reducir la vida del jugador
            // Dependiendo de c�mo quieras implementar tu trampa.

            // Ejemplo de reiniciar el nivel:
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

