using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGameManager : MonoBehaviour
{
    public Drop[] pillars;  // Asegúrate de asignar los pilares en el editor de Unity
    private int correctPillars = 0;
    public GameObject prefabToSpawn;
    private bool flag = true;

    void Update()
    {
        CheckPillars();
        // No necesitas inicializar los pilares aquí, ya que los asignarás manualmente en el editor
    }

    public void CheckPillars()
    {
        correctPillars = 0;

        foreach (Drop pilar in pillars)
        {
            // Compara el nombre del objeto Drag encima del pilar con el nombre esperado.
            if (pilar.currentDragObject != null && pilar.expectedTag == pilar.currentDragObject.gameObject.name)
            {
                correctPillars++;
            }
        }

        // Si todos los pilares tienen el objeto correcto, muestra un mensaje
        if (correctPillars == pillars.Length)
        {
            Debug.Log("¡Todos los pilares tienen los objetos correctos!");
            if(flag == true){
                Instantiate(prefabToSpawn, new Vector3(-1, 7, 4), Quaternion.identity);
                flag = false;
            }
            // Puedes agregar aquí cualquier lógica adicional que desees cuando todos los pilares estén correctos.
        }
        else
        {
            Debug.Log("No todos los pilares tienen los objetos correctos.");
        }
    }
}



