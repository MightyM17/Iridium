using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float up=10;
    public Button b1,b2;
    bool isonground=false;
    public AudioClip j;
    public Transform transform;
    private void Start() 
    {
         rb = GetComponent<Rigidbody>();
         transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey("w")||Input.GetKey(KeyCode.UpArrow))&&isonground)
        {
            AudioSource.PlayClipAtPoint(j, transform.position);
            rb.AddForce(0,up * Time.deltaTime,0,ForceMode.VelocityChange);
            isonground=false;
        }
    }
    public void button()
    {
            if(isonground)
        {
            rb.AddForce(0,(up-30) * Time.deltaTime,0,ForceMode.VelocityChange);
            isonground=false;
        }
    }
    private void OnCollisionStay(Collision other) {
        isonground=true;
    }
    
}
