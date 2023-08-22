using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Huevos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject puntaje = GameObject.FindGameObjectWithTag("Puntaje");

        puntaje.GetComponent<Puntaje>().PuntajeTotal++;

        puntaje.GetComponent<TextMeshProUGUI>().text =
            puntaje.GetComponent<Puntaje>().PuntajeTotal.ToString()+"/16";

        Destroy(gameObject);
    }
 
}
