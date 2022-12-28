using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreandhighscoredisplay : MonoBehaviour
{
    public Text score,hs;
    // Start is called before the first frame update
    void Start()
    {
        int x=highscore.disp;
        score.text="Score - "+x.ToString();
        hs.text="Highscore - "+PlayerPrefs.GetInt("highscore",0).ToString();
    }
}
