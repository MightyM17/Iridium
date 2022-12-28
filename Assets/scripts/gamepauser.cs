using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepauser : MonoBehaviour
{
    public static bool pause=false;
    public GameObject pausemenuui;
    public void Pause()
    {
        pausemenuui.SetActive(true);
        Time.timeScale=0f;
        pause=true;
    }
    public void Res()
    {
        pausemenuui.SetActive(false);
        Time.timeScale=1f;
        pause=false;
    }
}
