using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alllevelsdone : MonoBehaviour
{
    int coin,i;
    // Start is called before the first frame update
    void Start()
    {
        i=PlayerPrefs.GetInt("alldone");
        if(i!=2)
        {
        coin=PlayerPrefs.GetInt("coin");
        coin+=500;
        PlayerPrefs.SetInt("coin",coin);
        PlayerPrefs.SetInt("alldone",2);
        }
    }
}
