using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void LevelSelector()
    {
        SceneManager.LoadScene("Level Selector");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
