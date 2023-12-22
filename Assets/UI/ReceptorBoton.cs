using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ReceptorBoton : MonoBehaviour
{
    Button button;

    public void Start()
    {
        button = GetComponent<Button>();
    }

    public void OnPointerEnter()
    {
        button.animator.SetTrigger(button.animationTriggers.highlightedTrigger);
    }

    public void OnPointerExit()
    {
        button.animator.SetTrigger(button.animationTriggers.normalTrigger);
    }

    public void OnPointerClick()
    {
        button.animator.SetTrigger(button.animationTriggers.pressedTrigger);
        button.onClick.Invoke();
    }
}
