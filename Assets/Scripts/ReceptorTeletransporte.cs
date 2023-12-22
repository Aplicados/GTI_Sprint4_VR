using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptorTeletransporte : MonoBehaviour
{
    public Transform player;
    public void OnPointerClick(Vector3 poss)
    {
        player.position = new Vector3(poss.x, poss.y + 2.6f, poss.z);
    }
}
