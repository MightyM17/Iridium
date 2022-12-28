using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Transform player;
    public Text hs,txt;

    int s;
    public static int disp;
    void Start()
    {
        hs.text=PlayerPrefs.GetInt("highscore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        s=((int)player.position.z);
        disp=s;
        txt.text=s.ToString();
        if(s>PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore",s);
            
            hs.text=s.ToString();
        }
    }
}
