using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{

    public Animator animatorBoton;
    public Animator animatorPuerta;
    private AudioSource audioSource;
    public AudioClip audioClip;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(Vector3 poss)
    {
        audioSource.clip = audioClip;
        audioSource.PlayOneShot(audioClip);
        Debug.Log("animandooo");
        animatorBoton.SetTrigger("Pulsado");
        animatorPuerta.SetTrigger("botonpulsado");
    }
    
    void OnCollisionEnter(Collision collision)
    {
        audioSource.clip = audioClip;
        audioSource.PlayOneShot(audioClip);
        Debug.Log("animandooo");
        animatorBoton.SetTrigger("Pulsado");
        animatorPuerta.SetTrigger("botonpulsado");
    }

}
