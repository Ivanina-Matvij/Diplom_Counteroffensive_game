using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void OnLoadGame1()
    {
        SceneManager.LoadScene("GamePlay1");
    }
    public void OnLoadGame2()
    {
        SceneManager.LoadScene("GamePlay2");
    }
    public void OnLoadGame3()
    {
        SceneManager.LoadScene("GamePlay3");
    }
}
