using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static Vector3 savedPlayerPosition = Vector3.zero;

    public static bool tutorialDone = false;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static void SavePlayerPosition(Vector3 pos)
    {
        savedPlayerPosition = pos;
    }

}
