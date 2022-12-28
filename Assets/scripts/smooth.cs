using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smooth : MonoBehaviour
{
    public Transform plyr;
    public float sped=0.2f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 despos =plyr.position + offset;
        Vector3 smoothpos = Vector3.Lerp(transform.position , despos, sped);
        transform.position = smoothpos;
    // transform.LookAt(plyr);
      
    }
}
