using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bandeja : MonoBehaviour
{

    public bool[] llaves = {false, false};

    public UnityEvent completed;

    void Update() {

        if (llaves[0] && llaves[1]) {
            completed?.Invoke();
        }
    }


}
