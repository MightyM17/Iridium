using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplyr2 : MonoBehaviour
{
    public Rigidbody rb;
    public Transform t;
    public float forforce = 800f;
    public static float sideforce=20f;
    private float swidth;
    Quaternion target;
    public Vector3 spawn;   
   void Start()
   {
       swidth=Screen.width/2;
   }
    void Update()
    {
        rb.AddForce (0,0,forforce * Time.deltaTime);
        target = Quaternion.Euler(forforce * Time.deltaTime,0, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5);
        Keyboard();
        if(t.position.y<-1)
        {
            t.transform.position=spawn;
        }
    }

    void Keyboard()
    {
        if(Input.GetKey("right"))
        {
            rb.AddForce (sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            target = Quaternion.Euler(0, sideforce * Time.deltaTime, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5); 
        }
        if(Input.GetKey("left"))
        {
            rb.AddForce (-sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            target = Quaternion.Euler(0, -sideforce * Time.deltaTime, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5);
        }
    }
}
