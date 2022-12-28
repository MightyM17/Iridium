using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public Transform plyr;
    public GameObject lefts,rights,jumps;
    int k=0;
    void Update()
    {
        if((int)plyr.position.z>=20&&(int)plyr.position.z<=30)
        {
            rights.SetActive(true);
            if(k==1)
            {
                Time.timeScale=1.0f;
            }
            else
            Time.timeScale=0f;
            //
            if (Input.anyKeyDown)
            {
                k=1;
            }
        }
        else
        rights.SetActive(false);

        if((int)plyr.position.z>=45&&(int)plyr.position.z<=55)
         {
            lefts.SetActive(true);
            if(k==2)
            {
                Time.timeScale=1.0f;
            }
            else
            Time.timeScale=0f;
            //
            if (Input.anyKeyDown)
            {
                k=2;
            }
        }
        else
        lefts.SetActive(false);

        if((int)plyr.position.z>=96&&(int)plyr.position.z<=107)
        {
            jumps.SetActive(true);
            if(k==1)
            {
                Time.timeScale=1.0f;
            }
            else
            Time.timeScale=0f;
            //
            if (Input.anyKeyDown)
            {
                k=1;
            }
        }
        else
        jumps.SetActive(false);
    }
}
