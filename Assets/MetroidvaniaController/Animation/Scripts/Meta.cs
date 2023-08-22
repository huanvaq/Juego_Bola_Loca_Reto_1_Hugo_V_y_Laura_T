using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject panelGanar;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        panelGanar.SetActive(true);
    }

}
