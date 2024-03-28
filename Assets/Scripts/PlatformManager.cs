using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class PlatformManager : MonoBehaviour
{
    public PrometeoCarController Controller;
    [SerializeField] GameObject MobileUI;
    [SerializeField] GameObject PauseMenuMobile;
    [SerializeField] GameObject PauseMenuPC;
    void Start()
    {
#if(UNITY_ANDROID || UNITY_IOS)
        {
            Controller.useTouchControls = true;
            MobileUI.SetActive(true);
            PauseMenuMobile.SetActive(true);
        }
#elif UNITY_STANDALONE
            {
                Controller.useTouchControls = false;
                MobileUI.SetActive(false);
                PauseMenuPC.SetActive(true);
            }
#endif
    }
}

