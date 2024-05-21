using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LoadMenu : MonoBehaviour
{
    public void Button_Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
