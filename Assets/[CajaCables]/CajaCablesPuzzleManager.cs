using UnityEngine;
using UnityEngine.Events;

public class CajaCablesPuzzleManager : MonoBehaviour
{
    [SerializeField] GameObject caja;

    public UnityEvent OnPuzzleCompleted;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip clip2;
    private bool auidoPlayed = false;


    int cables_count = 0;

    public void CableConnected()
    {
        cables_count++;
        Debug.Log(cables_count);
        CheckPuzzle();
    }

    void CheckPuzzle()
    {
        if (cables_count == 3)
        {
            //Puzzle completed
            Debug.Log("All cables connected!");
            OnPuzzleCompleted?.Invoke();
            audioSource.clip = clip2;
            audioSource.PlayOneShot(clip2);
            
        }
    }
    public void AbrirCaja(bool abrir)
    {
        caja.GetComponent<Animator>().SetBool("opened", abrir);
        if (auidoPlayed == false)
        {
            audioSource.clip = clip;
            audioSource.PlayOneShot(clip);
            auidoPlayed=true;
        }
    }

}