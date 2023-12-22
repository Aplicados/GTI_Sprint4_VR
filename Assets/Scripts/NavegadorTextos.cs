using UnityEngine;
using UnityEngine.UI;

public class NavegadorTextos : MonoBehaviour
{
    public GameObject[] panelesTextos; // Arreglo de paneles de instrucciones.
    public Button prevButton;
    public Button nextButton;
    private int currentIndex = 0; // Índice del panel actualmente visible.
    public Canvas canvasIntro;

    void Start()
    {
        if (GameManager.tutorialDone)
        {
            canvasIntro.gameObject.SetActive(false);
        }
        else
        {
            UpdateUI();
        }
    }

    // Llamado cuando se presiona el botón "Anterior".
    public void ShowPreviousInstruction()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdateUI();
        }
    }

    // Llamado cuando se presiona el botón "Siguiente".
    public void ShowNextInstruction()
    {
        if (currentIndex < panelesTextos.Length - 1)
        {
            currentIndex++;
            UpdateUI();
        }
        //Si es el ultimo panel, desactiva todo el canvas
        else if (currentIndex == panelesTextos.Length - 1)
        {
            canvasIntro.gameObject.SetActive(false);
            GameManager.tutorialDone = true;

        }
    }

    // Actualiza la interfaz de usuario.
    void UpdateUI()
    {
        // Desactiva todos los paneles.
        for (int i = 0; i < panelesTextos.Length; i++)
        {
            panelesTextos[i].SetActive(false);
        }

        // Activa solo el panel actual.
        panelesTextos[currentIndex].SetActive(true);

        // Actualiza el estado de los botones.
        prevButton.interactable = (currentIndex > 0);
        //nextButton.interactable = (currentIndex < panelesTextos.Length - 1);


    }
}
