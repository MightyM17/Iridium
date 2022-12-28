using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public Transform plyr,particle;
    Vector3 ppos;

    // Update is called once per frame
    void Update()
    {
        ppos=(plyr.position);
        ppos.y-=0.4f;//,plyr.position.y-0.5,plyr.position.z);
        particle.position=ppos;
    }
}
