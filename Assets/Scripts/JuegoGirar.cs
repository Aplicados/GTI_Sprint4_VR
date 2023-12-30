using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoGirar : MonoBehaviour
{
    public Material nuevoMaterial; // El nuevo material que esta encendido
    public Material materialApagado; // El matrial de apagado
    public GameObject[] objetosDeLaSala; // Los objetos de la sala a los quecambiar el material

    public GameObject tapaBajada,tapaSubida;//la tapa de la caja

    
   
     void Update()
    {
        // Obtener la rotación actual del objeto
        Vector3 rotacionActual = transform.rotation.eulerAngles;

        // Imprimir la rotación en tiempo real
        Debug.Log("Rotación actual: " + rotacionActual);

        float umbralTolerancia = 1.0f; 
        Quaternion rotacionObjeto = transform.rotation;
        

        // Verificar si la rotación cumple con la condición
        if (Mathf.Abs(rotacionObjeto.eulerAngles.x) < umbralTolerancia &&
            Mathf.Abs(rotacionObjeto.eulerAngles.y - 90.0f) < umbralTolerancia &&
            Mathf.Abs(rotacionObjeto.eulerAngles.z) < umbralTolerancia)
        {
            // Cambiar el material de los objetos de la sala
            foreach (GameObject objeto in objetosDeLaSala)
            {
                CambiarMaterialDelObjeto(objeto);
            }
            
        }else{
            // Cambiar el material de los objetos de la sala
            foreach (GameObject objeto in objetosDeLaSala)
            {
                CambiarApagado(objeto);
            }
        }
    }


    void CambiarMaterialDelObjeto(GameObject objeto)
    {
        Renderer rendererTapaB = tapaBajada.GetComponent<Renderer>();
        rendererTapaB.enabled = false;

        Renderer rendererTapaS = tapaSubida.GetComponent<Renderer>();
        rendererTapaS.enabled = true;
        
        // Verificar si el objeto tiene un renderer
        Renderer renderer = objeto.GetComponent<Renderer>();
        if (renderer != null)
        {
            // Cambiar el material
            renderer.material = nuevoMaterial;
        }
        else
        {
            Debug.LogError("El objeto no tiene un componente Renderer.");
        }
    }
    void CambiarApagado(GameObject objeto)
    {
        Renderer rendererTapaB = tapaBajada.GetComponent<Renderer>();
        rendererTapaB.enabled = true;

        Renderer rendererTapaS = tapaSubida.GetComponent<Renderer>();
        rendererTapaS.enabled = false;
        // Verificar si el objeto tiene un renderer
        Renderer renderer = objeto.GetComponent<Renderer>();
        if (renderer != null)
        {
            // Cambiar el material
            renderer.material =materialApagado;
        }
        else
        {
            Debug.LogError("El objeto no tiene un componente Renderer.");
        }
    }
}