using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void ShutokoLoader()
    {
        SceneManager.LoadScene("Shutoko Highway");
    }
    public void SnowHillLoader()
    {
        SceneManager.LoadScene("Snow Hill County");
    }
}
