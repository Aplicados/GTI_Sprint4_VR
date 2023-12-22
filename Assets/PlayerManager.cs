using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting player pos from GM:" + GameManager.savedPlayerPosition);
        if (GameManager.savedPlayerPosition != Vector3.zero)
        {
            transform.position = GameManager.savedPlayerPosition;
        }
    }

    private void OnDestroy()
    {
        GameManager.savedPlayerPosition = transform.position;
        Debug.Log("Saving player pos to GM - actual transform:" + transform.position);
        Debug.Log("Saving player pos to GM - actual saved:" + GameManager.savedPlayerPosition);
    }

}
