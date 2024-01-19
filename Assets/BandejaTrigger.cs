using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandejaTrigger : MonoBehaviour
{
    
    public int numLlave;
    public Bandeja bandeja;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("llave enter");
        if (other.gameObject.CompareTag("Llave")) {
            bandeja.llaves[numLlave] = true;
            bandeja.contador++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("llave exit");
        if (other.gameObject.CompareTag("Llave")) {
            bandeja.llaves[numLlave] = false;
            bandeja.contador--;
        }
    }
}
