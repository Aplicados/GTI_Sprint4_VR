using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecondGameManager : MonoBehaviour
{
    public Drop[] pillars;
    private int correctPillars = 0;
    private int incorrectPillars = 0;
    public GameObject prefabToSpawn;
    public TextMeshProUGUI texto;

    private bool flag = true;

    void Update()
    {
        CheckPillars();
    }

    public void CheckPillars()
    {
        correctPillars = 0;
        incorrectPillars = 0;

        foreach (Drop pilar in pillars)
        {
            if (pilar.currentDragObject != null)
            {
                if (pilar.expectedTag == pilar.currentDragObject.gameObject.name)
                {
                    correctPillars++;
                }
                else
                {
                    incorrectPillars++;
                }
            }
        }

        texto.text = $"{correctPillars}/4";

        if (correctPillars == pillars.Length)
        {
            Debug.Log("¡Todos los pilares tienen los objetos correctos!");

            if (flag)
            {
                Instantiate(prefabToSpawn, new Vector3(-1, 7, 4), Quaternion.identity);
                flag = false;
            }
        }
        else
        {
            Debug.Log("No todos los pilares tienen los objetos correctos.");
        }

        // Restar cuando hay pilares incorrectos
        int incorrectToSubtract = incorrectPillars > 0 ? 1 : 0;
        correctPillars = Mathf.Max(0, correctPillars - incorrectToSubtract);
    }
}




