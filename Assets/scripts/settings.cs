using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer a;
    //public movement m;
    public Slider volslider,movslider;
    void Start()
    {
        volslider.value=PlayerPrefs.GetFloat("vol",0);
        movslider.value=PlayerPrefs.GetFloat("move",20);
    }
    public void Vol(float volume)
    {
        PlayerPrefs.SetFloat("vol",volume);
        a.SetFloat("volume", PlayerPrefs.GetFloat("vol"));
        
    }
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
    public void Sen(float s)
    {
        PlayerPrefs.SetFloat("move",s);
        movement.sideforce=s;
        movement1.sideforce=s;
        movementplyr1.sideforce=s;
        movementplyr2.sideforce=s;
    }
}
