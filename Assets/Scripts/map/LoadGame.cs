using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        int unlockedLevels = PlayerPrefs.GetInt("UnlockedLevel", 1);
        Debug.Log("UnlockedLevels: " + unlockedLevels);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        int maxLevels = Mathf.Min(unlockedLevels, buttons.Length);
        for (int i = 0; i < maxLevels; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void OnLoadGame(int LevelId)
    {
        string LevelName = "GamePlay" + LevelId;
        SceneManager.LoadScene(LevelName);
    }
}
