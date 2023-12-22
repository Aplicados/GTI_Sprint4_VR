using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReceiveHit : MonoBehaviour
{
    public UnityEvent myEventClick;
    public UnityEvent myEventEnter;
    public UnityEvent myEventExit;
    public void OnPointerEnter()
    {
        myEventEnter.Invoke();
    }

    public void OnPointerExit()
    {
        myEventExit.Invoke();
    }

    public void OnPointerClick()
    {
        myEventClick.Invoke();
    }

}