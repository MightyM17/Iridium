using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public ParticleSystem p;
    public Transform t;
    public Rigidbody x;
    Vector3 spawn;
    // Update is called once per frame
    void Update()
    {
        if((int)t.position.z%24==0)
        {
            spawn = new Vector3(0f, 0.5f, (int)t.position.z);
        }
        if(t.position.y<-1)
        {

            t.position=spawn;
            x.isKinematic = true;
            
            x.isKinematic = false;
            //p.Play();
        }
    }
}
