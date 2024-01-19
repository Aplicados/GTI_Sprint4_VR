using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class Bandeja : MonoBehaviour
{

    public bool[] llaves = {false, false};

    public UnityEvent completed;
    public TextMeshProUGUI texto;
    public int contador = 0;

    void Update() {
        texto.text = (contador).ToString() + "/2";

        if (llaves[0] && llaves[1]) {
            completed?.Invoke();
        }
    }


}
