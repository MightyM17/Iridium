using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Animator transition;
    public Transform plyr;
    public Vector3 spawnpos;

    public void EndGame () 
    {
        if(plyr.position.y<-1) 
        {
            StartCoroutine (LoadScene());
        }

    }
    IEnumerator LoadScene () 
    {
        transition.SetTrigger ("end");
        yield return new WaitForSeconds (1f);
        plyr.position=spawnpos;
    }
}

