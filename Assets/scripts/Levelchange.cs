using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelchange : MonoBehaviour
{
    public GameObject panel,next,prev;
    public void ChangePlus()
    {
        panel.SetActive(false); 
        next.SetActive(true);
    }
    public void ChangeMinus()
    {
        panel.SetActive(false); 
        prev.SetActive(true);
    }
}
