using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        // ����� � �������� ��� ��������� ������ Escape
        if (Input.GetKey(KeyCode.Escape))
        {
            QuitApplication();
        }
    }

    void QuitApplication()
    {
        // ����� � ��������
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}