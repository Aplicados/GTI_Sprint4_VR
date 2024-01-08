using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Material highMat;
    private Material ownMat;
    public string expectedTag = "Cuadrado";
    public Drag currentDragObject = null; // Referencia al objeto Drag actualmente encima del Drop.

    void Start()
    {
        ownMat = this.GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        Drag dragComponent = other.GetComponent<Drag>();
        if (dragComponent != null)
        {
            this.GetComponent<Renderer>().material = highMat;
            currentDragObject = dragComponent; // Almacena la referencia al objeto Drag actual.
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Drag dragComponent = other.GetComponent<Drag>();
        if (dragComponent != null && currentDragObject == dragComponent)
        {
            this.GetComponent<Renderer>().material = ownMat;
            currentDragObject = null; // Limpia la referencia cuando el objeto Drag sale.
        }
    }
}


