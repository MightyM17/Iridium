using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1rev : MonoBehaviour
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
        Touch();
        if(t.position.y<-1)
        {
            t.transform.position=spawn;
        }
    }
    /*void Tilt()
    {
        rb.AddForce((Input.acceleration.x*Time.deltaTime)*880,0,0);
        target = Quaternion.Euler(0, (Input.acceleration.x)*880 * Time.deltaTime, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5);
    }*/
    void Touch()
    {
        if(Input.touchCount>0)
        {
            Touch t=Input.GetTouch(0);
            if(t.position.x>swidth)
            {
                rb.AddForce (-sideforce/2* Time.deltaTime,0,0,ForceMode.VelocityChange);
                target = Quaternion.Euler(0, sideforce/2 * Time.deltaTime, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5); 
            }
            else if(t.position.x<swidth)
            {
            rb.AddForce (sideforce/2 * Time.deltaTime,0,0,ForceMode.VelocityChange);
            target = Quaternion.Euler(0, -sideforce/2 * Time.deltaTime, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5);
            }
        }
    }
    void Keyboard()
    {
        if(Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce (-sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            target = Quaternion.Euler(0, sideforce * Time.deltaTime, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5); 
        }
        if(Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce (sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            target = Quaternion.Euler(0, -sideforce * Time.deltaTime, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5);
        }
    }
}
