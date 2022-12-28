using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seed : MonoBehaviour
{
    public static int seedno;
    public InputField f;
    void Start()
    {
        PlayerPrefs.SetInt("seed",0);
    }
    public void seedenter()
    {
        seedno=int.Parse(f.text);
        PlayerPrefs.SetInt("seed",1);
    }
}
