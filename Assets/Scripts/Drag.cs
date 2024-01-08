using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Drag : MonoBehaviour
{
    [HideInInspector]
    public Drop currentDropSlot;
    public void onDrop()
    {
        if (currentDropSlot != null)
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            transform.position =
            currentDropSlot.transform.position;
            transform.rotation =
            currentDropSlot.transform.rotation;
            currentDropSlot.gameObject.SetActive(false);
        }
    }
}
