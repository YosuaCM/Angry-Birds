using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Option : MonoBehaviour
{
    public void Scene_1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Scene_2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Exit()
    {
        Application.Quit();
    }
}