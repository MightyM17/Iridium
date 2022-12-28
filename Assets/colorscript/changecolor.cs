using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public GameObject otherobj;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("color")==0)
        blue();
        if(PlayerPrefs.GetInt("color")==1)
        red();
        if(PlayerPrefs.GetInt("color")==2)
        green();
        if(PlayerPrefs.GetInt("color")==3)
        cyan();
        if(PlayerPrefs.GetInt("color")==4)
        yellow();
        if(PlayerPrefs.GetInt("color")==5)
        rndm();
    }

    void blue()
    {
        otherobj.GetComponent<redc>().enabled = false;
        otherobj.GetComponent<greenc>().enabled = false;
        otherobj.GetComponent<cyanc>().enabled = false;
        otherobj.GetComponent<yellowc>().enabled = false;
        otherobj.GetComponent<colofr>().enabled = false;
    }
    void red()
    {
        otherobj.GetComponent<redc>().enabled = true;
        //
        otherobj.GetComponent<greenc>().enabled = false;
        otherobj.GetComponent<cyanc>().enabled = false;
        otherobj.GetComponent<yellowc>().enabled = false;
        otherobj.GetComponent<colofr>().enabled = false;
    }
    void green()
    {
        otherobj.GetComponent<greenc>().enabled = true;
        //
         otherobj.GetComponent<redc>().enabled = false;
        otherobj.GetComponent<cyanc>().enabled = false;
        otherobj.GetComponent<yellowc>().enabled = false;
        otherobj.GetComponent<colofr>().enabled = false;
    }
    void yellow()
    {
        otherobj.GetComponent<yellowc>().enabled = true;
        //
         otherobj.GetComponent<greenc>().enabled = false;
        otherobj.GetComponent<cyanc>().enabled = false;
        otherobj.GetComponent<redc>().enabled = false;
        otherobj.GetComponent<colofr>().enabled = false;
    }
    void cyan()
    {
        otherobj.GetComponent<cyanc>().enabled = true;
        //
         otherobj.GetComponent<greenc>().enabled = false;
        otherobj.GetComponent<redc>().enabled = false;
        otherobj.GetComponent<yellowc>().enabled = false;
        otherobj.GetComponent<colofr>().enabled = false;
    }
    void rndm()
    {
         otherobj.GetComponent<colofr>().enabled = true;
        //
         otherobj.GetComponent<greenc>().enabled = false;
        otherobj.GetComponent<cyanc>().enabled = false;
        otherobj.GetComponent<yellowc>().enabled = false;
        otherobj.GetComponent<redc>().enabled = false;
    }
}
