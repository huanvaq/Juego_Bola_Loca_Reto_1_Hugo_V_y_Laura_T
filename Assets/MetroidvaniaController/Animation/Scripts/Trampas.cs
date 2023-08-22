using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Aquí puedes agregar la lógica para aplicar la trampa
            // Por ejemplo, reiniciar el nivel o reducir la vida del jugador
            // Dependiendo de cómo quieras implementar tu trampa.

            // Ejemplo de reiniciar el nivel:
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

