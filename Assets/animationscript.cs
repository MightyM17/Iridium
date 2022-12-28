using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationscript : MonoBehaviour
{
    float t;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {t=(int)Time.time%10;
        if(t==1)
        txt.text="2";
        if(t==2)
        txt.text="1";
        if(t==3)
        txt.text="Begin";
        if(t>3)
        txt.text="";
    }
}
