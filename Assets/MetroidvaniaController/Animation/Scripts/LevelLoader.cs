using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string levelToLoad; // Nombre o índice del nivel a cargar

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Cargar el siguiente nivel cuando el jugador toque la meta
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

