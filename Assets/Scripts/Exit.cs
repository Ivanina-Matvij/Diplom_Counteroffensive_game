using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        // Вихід з програми при натисканні клавіші Escape
        if (Input.GetKey(KeyCode.Escape))
        {
            QuitApplication();
        }
    }

    void QuitApplication()
    {
        // Вихід з програми
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}