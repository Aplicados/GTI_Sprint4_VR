using UnityEngine;
using UnityEngine.Events;

public class CajaCablesPuzzleManager : MonoBehaviour
{
    [SerializeField] GameObject caja;

    public UnityEvent OnPuzzleCompleted;

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
            
        }
    }
    public void AbrirCaja(bool abrir)
    {
        caja.GetComponent<Animator>().SetBool("opened", abrir);
    }

}